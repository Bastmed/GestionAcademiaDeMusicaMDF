using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GestionAcademaDeMusica.Formularios.Profesores
{
    public partial class AgregarProfesor : Form
    {
        private AcademiaRepositorio _repo = new AcademiaRepositorio();

        private static readonly string[] PrefijosLatam = {
            "+54 (Argentina)", "+591 (Bolivia)", "+55 (Brasil)", "+56 (Chile)",
            "+57 (Colombia)", "+506 (Costa Rica)", "+53 (Cuba)", "+593 (Ecuador)",
            "+503 (El Salvador)", "+502 (Guatemala)", "+509 (Haití)", "+504 (Honduras)",
            "+52 (México)", "+505 (Nicaragua)", "+507 (Panamá)", "+595 (Paraguay)",
            "+51 (Perú)", "+1 (Puerto Rico)", "+1 (Rep. Dominicana)", "+598 (Uruguay)",
            "+58 (Venezuela)"
        };

        public AgregarProfesor()
        {
            InitializeComponent();
            btnRegistrarPro.Click += btnRegistrarProfe_Click;

            clbEspecialidadesAgrProfe.ItemCheck += clbEspecialidadesAgrProfe_ItemCheck;

            cmbTelefonoAgrProfesor.Items.AddRange(PrefijosLatam);
            cmbTelefonoAgrProfesor.SelectedIndex = 3; // Chile por defecto
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

        private void btnRegistrarProfe_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreAgrProfe.Text) || string.IsNullOrWhiteSpace(txtApellidoAgrProfe.Text))
            {
                MessageBox.Show("El nombre y apellido son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!NombreValido(txtNombreAgrProfe.Text))
            {
                MessageBox.Show("El nombre solo puede contener letras.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!NombreValido(txtApellidoAgrProfe.Text))
            {
                MessageBox.Show("El apellido solo puede contener letras.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(txtTarifaAgrProfe.Text.Trim(), out decimal tarifa) || tarifa <= 0)
            {
                MessageBox.Show("La tarifa debe ser un número mayor a 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!string.IsNullOrWhiteSpace(txtEmailAgrProfe.Text) && !EmailValido(txtEmailAgrProfe.Text.Trim()))
            {
                MessageBox.Show("El email ingresado no es válido.\nejemplo: usuario@gmail.com", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string telefonoFinal = "";
            if (!string.IsNullOrWhiteSpace(txtTelefonoAgrProfe.Text))
            {
                if (!TelefonoValido(txtTelefonoAgrProfe.Text))
                {
                    MessageBox.Show("El número de teléfono debe contener solo dígitos (7 a 12).\nejemplo: 912345678", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string prefijo = cmbTelefonoAgrProfesor.SelectedItem?.ToString().Split(' ')[0] ?? "";
                telefonoFinal = prefijo + " " + txtTelefonoAgrProfe.Text.Trim();
            }
            
            List<string> especialidadesSeleccionadas = new List<string>();

            
            foreach (var item in clbEspecialidadesAgrProfe.CheckedItems)
            {
                especialidadesSeleccionadas.Add(item.ToString());
            }

            if (especialidadesSeleccionadas.Count == 0)
            {
                MessageBox.Show("Debe seleccionar al menos una especialidad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string especialidadesUnidas = string.Join(", ", especialidadesSeleccionadas);
            Profesor nuevoProfesor = new Profesor
            {
                NombreProfesor = txtNombreAgrProfe.Text.Trim(),
                ApellidoProfesor = txtApellidoAgrProfe.Text.Trim(),
                TelefonoProfesor = telefonoFinal,
                EmailProfesor = txtEmailAgrProfe.Text.Trim(),
                Especialidad = especialidadesUnidas,
                TarifaHora = tarifa,
                ActivoProfesor = chkEstadoAgrProfe.Checked
            };

            _repo.AgregarProfesor(nuevoProfesor);
            MessageBox.Show("Profesor agregado exitosamente.");
            this.Close();
        }

        private void txtTarifaAgrProfe_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtTarifaAgrProfe.Text.Trim(), out decimal tarifaBase))
                lblTarifaIVA.Text = $"Con IVA (19%): {tarifaBase * 1.19m:C}";
            else
                lblTarifaIVA.Text = "Con IVA (19%): $0";
        }

        private void clbEspecialidadesAgrProfe_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                if (clbEspecialidadesAgrProfe.CheckedItems.Count >= 7)
                {
                    MessageBox.Show("Ya has alcanzado el máximo de 7 especialidades permitidas.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    e.NewValue = CheckState.Unchecked;
                }
            }
        }

        private void txtTarifaAgrProfe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtTelefonoAgrProfe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNombreAgrProfe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtApellidoAgrProfe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}