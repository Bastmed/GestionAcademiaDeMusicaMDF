using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GestionAcademaDeMusica.Formularios.Profesores
{
    public partial class ActualizarProfesor : Form
    {
        private AcademiaRepositorio _repo = new AcademiaRepositorio();
        private Profesor _profesor;

        private static readonly string[] PrefijosLatam = {
            "+54 (Argentina)", "+591 (Bolivia)", "+55 (Brasil)", "+56 (Chile)",
            "+57 (Colombia)", "+506 (Costa Rica)", "+53 (Cuba)", "+593 (Ecuador)",
            "+503 (El Salvador)", "+502 (Guatemala)", "+509 (Haití)", "+504 (Honduras)",
            "+52 (México)", "+505 (Nicaragua)", "+507 (Panamá)", "+595 (Paraguay)",
            "+51 (Perú)", "+1 (Puerto Rico)", "+1 (Rep. Dominicana)", "+598 (Uruguay)",
            "+58 (Venezuela)"
        };

        public ActualizarProfesor(Profesor seleccionado)
        {
            InitializeComponent();
            _profesor = seleccionado;
            btnActualizarPro.Click += btnActualizarProfe_Click;
            this.Load += ActualizarProfesor_Load;

            cmbTelefonoActProfesor.Items.AddRange(PrefijosLatam);
            cmbTelefonoActProfesor.SelectedIndex = 3; // Chile por defecto
        }

        private void ActualizarProfesor_Load(object sender, EventArgs e)
        {
            txtNombreActProfe.Text = _profesor.NombreProfesor;
            txtApellidoActProfe.Text = _profesor.ApellidoProfesor;
            txtEmailActProfe.Text = _profesor.EmailProfesor;
            txtTarifaActProfe.Text = _profesor.TarifaHora.ToString();
            chkEstadoActProfe.Checked = _profesor.ActivoProfesor;

            if (!string.IsNullOrEmpty(_profesor.Especialidad))
            {
                var listaEspecialidades = _profesor.Especialidad.Split(new[] { ", " }, StringSplitOptions.None);
                for (int i = 0; i < clbEspecialidadesActProfe.Items.Count; i++)
                {
                    if (listaEspecialidades.Contains(clbEspecialidadesActProfe.Items[i].ToString()))
                    {
                        clbEspecialidadesActProfe.SetItemChecked(i, true);
                    }
                }
            }

            if (!string.IsNullOrWhiteSpace(_profesor.TelefonoProfesor))
            {
                string[] partes = _profesor.TelefonoProfesor.Split(new char[] { ' ' }, 2);
                if (partes.Length == 2)
                {
                    string prefijoGuardado = partes[0];
                    for (int i = 0; i < PrefijosLatam.Length; i++)
                    {
                        if (PrefijosLatam[i].StartsWith(prefijoGuardado))
                        {
                            cmbTelefonoActProfesor.SelectedIndex = i;
                            break;
                        }
                    }
                    txtTelefonoActProfe.Text = partes[1];
                }
                else
                {
                    txtTelefonoActProfe.Text = _profesor.TelefonoProfesor;
                }
            }
        }

        private bool NombreValido(string texto)
        {
            return Regex.IsMatch(texto.Trim(), @"^[a-zA-ZáéíóúÁÉÍÓÚüÜñÑ\s]+$");
        }

        private bool EmailValido(string email)
        {
            try { var a = new System.Net.Mail.MailAddress(email); return a.Address == email; }
            catch { return false; }
        }

        private bool TelefonoValido(string numero)
        {
            return Regex.IsMatch(numero.Trim(), @"^\d{7,12}$");
        }

        private void btnActualizarProfe_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreActProfe.Text) || string.IsNullOrWhiteSpace(txtApellidoActProfe.Text))
            {
                MessageBox.Show("El nombre y apellido son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!NombreValido(txtNombreActProfe.Text))
            {
                MessageBox.Show("El nombre solo puede contener letras.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!NombreValido(txtApellidoActProfe.Text))
            {
                MessageBox.Show("El apellido solo puede contener letras.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(txtTarifaActProfe.Text.Trim(), out decimal tarifa) || tarifa <= 0)
            {
                MessageBox.Show("La tarifa debe ser un número mayor a 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!string.IsNullOrWhiteSpace(txtEmailActProfe.Text) && !EmailValido(txtEmailActProfe.Text.Trim()))
            {
                MessageBox.Show("El email ingresado no es válido.\nejemplo: usuario@gmail.com", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string telefonoFinal = "";
            if (!string.IsNullOrWhiteSpace(txtTelefonoActProfe.Text))
            {
                if (!TelefonoValido(txtTelefonoActProfe.Text))
                {
                    MessageBox.Show("El número de teléfono debe contener solo dígitos (7 a 12).\nejemplo: 912345678", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string prefijo = cmbTelefonoActProfesor.SelectedItem?.ToString().Split(' ')[0] ?? "";
                telefonoFinal = prefijo + " " + txtTelefonoActProfe.Text.Trim();
            }

            List<string> especialidadesSeleccionadas = new List<string>();
            foreach (var item in clbEspecialidadesActProfe.CheckedItems)
            {
                especialidadesSeleccionadas.Add(item.ToString());
            }

            if (especialidadesSeleccionadas.Count == 0)
            {
                MessageBox.Show("Debe seleccionar al menos una especialidad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string especialidadesUnidas = string.Join(", ", especialidadesSeleccionadas);

            _profesor.NombreProfesor = txtNombreActProfe.Text.Trim();
            _profesor.ApellidoProfesor = txtApellidoActProfe.Text.Trim();
            _profesor.TelefonoProfesor = telefonoFinal;
            _profesor.EmailProfesor = txtEmailActProfe.Text.Trim();
            _profesor.Especialidad = especialidadesUnidas; 
            _profesor.TarifaHora = tarifa;
            _profesor.ActivoProfesor = chkEstadoActProfe.Checked;

            _repo.ActualizarProfesor(_profesor);
            MessageBox.Show("Profesor actualizado correctamente.");
            this.Close();
        }

        private void txtTarifaActProfe_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtTarifaActProfe.Text.Trim(), out decimal tarifaBase))
                lblTarifaIVA.Text = $"Con IVA (19%): {tarifaBase * 1.19m:C}";
            else
                lblTarifaIVA.Text = "Con IVA (19%): $0";
        }

        private void lblTarifaIVA_Click(object sender, EventArgs e) { }

        private void clbEspecialidadesActProfe_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                if (clbEspecialidadesActProfe.CheckedItems.Count >= 7)
                {
                    MessageBox.Show("Un profesor no puede tener más de 7 especialidades.", "Límite alcanzado", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    e.NewValue = CheckState.Unchecked;
                }
            }
        }
    }
}