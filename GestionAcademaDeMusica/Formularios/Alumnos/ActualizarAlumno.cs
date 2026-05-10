using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GestionAcademaDeMusica.Formularios.Alumnos
{
    public partial class ActualizarAlumno : Form
    {
        private AcademiaRepositorio _repo = new AcademiaRepositorio();
        private Alumno _alumno;

        private static readonly string[] PrefijosLatam = {
            "+54 (Argentina)", "+591 (Bolivia)", "+55 (Brasil)", "+56 (Chile)",
            "+57 (Colombia)", "+506 (Costa Rica)", "+53 (Cuba)", "+593 (Ecuador)",
            "+503 (El Salvador)", "+502 (Guatemala)", "+509 (Haití)", "+504 (Honduras)",
            "+52 (México)", "+505 (Nicaragua)", "+507 (Panamá)", "+595 (Paraguay)",
            "+51 (Perú)", "+1 (Puerto Rico)", "+1 (Rep. Dominicana)", "+598 (Uruguay)",
            "+58 (Venezuela)"
        };

        public ActualizarAlumno(Alumno seleccionado)
        {
            InitializeComponent();
            _alumno = seleccionado;

            cmbTelefonoActAlumno.Items.AddRange(PrefijosLatam);
            cmbTelefonoActAlumno.SelectedIndex = 3; // Chile por defecto

            cmbInstrumentoAlumno.DisplayMember = "NombreInstrumento";
            cmbInstrumentoAlumno.ValueMember = "IdInstrumento";
            cmbInstrumentoAlumno.DataSource = _repo.ObtenerInstrumentos();
        }

        private void ActualizarAlumno_Load(object sender, EventArgs e)
        {
            txtNombreAlumno.Text = _alumno.NombreAlumno;
            txtApellidoAlumno.Text = _alumno.ApellidoAlumno;
            dtpFechaAlumno.Value = _alumno.FechaNacimiento;
            txtEmailAlumno.Text = _alumno.EmailAlumno;
            chkEstadoAlumno.Checked = _alumno.ActivoAlumno;

            // Separar prefijo y número del teléfono guardado
            if (!string.IsNullOrWhiteSpace(_alumno.TelefonoAlumno))
            {
                string[] partes = _alumno.TelefonoAlumno.Split(new char[] { ' ' }, 2);
                if (partes.Length == 2)
                {
                    // Buscar el prefijo en la lista
                    string prefijoGuardado = partes[0];
                    for (int i = 0; i < PrefijosLatam.Length; i++)
                    {
                        if (PrefijosLatam[i].StartsWith(prefijoGuardado))
                        {
                            cmbTelefonoActAlumno.SelectedIndex = i;
                            break;
                        }
                    }
                    txtTelefonoAlumno.Text = partes[1];
                }
                else
                {
                    txtTelefonoAlumno.Text = _alumno.TelefonoAlumno;
                }
            }

            if (_alumno.IdInstrumento != null)
                cmbInstrumentoAlumno.SelectedValue = _alumno.IdInstrumento;
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

        private void btnActu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreAlumno.Text) || string.IsNullOrWhiteSpace(txtApellidoAlumno.Text))
            {
                MessageBox.Show("El nombre y apellido son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!NombreValido(txtNombreAlumno.Text))
            {
                MessageBox.Show("El nombre solo puede contener letras.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!NombreValido(txtApellidoAlumno.Text))
            {
                MessageBox.Show("El apellido solo puede contener letras.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!string.IsNullOrWhiteSpace(txtEmailAlumno.Text) && !EmailValido(txtEmailAlumno.Text.Trim()))
            {
                MessageBox.Show("El email ingresado no es válido.\nejemplo: usuario@gmail.com", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string telefonoFinal = "";
            if (!string.IsNullOrWhiteSpace(txtTelefonoAlumno.Text))
            {
                if (!TelefonoValido(txtTelefonoAlumno.Text))
                {
                    MessageBox.Show("El número de teléfono debe contener solo dígitos (7 a 12).\nejemplo: 912345678", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string prefijo = cmbTelefonoActAlumno.SelectedItem?.ToString().Split(' ')[0] ?? "";
                telefonoFinal = prefijo + " " + txtTelefonoAlumno.Text.Trim();
            }

            _alumno.NombreAlumno = txtNombreAlumno.Text.Trim();
            _alumno.ApellidoAlumno = txtApellidoAlumno.Text.Trim();
            _alumno.FechaNacimiento = dtpFechaAlumno.Value;
            _alumno.TelefonoAlumno = telefonoFinal;
            _alumno.EmailAlumno = txtEmailAlumno.Text.Trim();
            _alumno.ActivoAlumno = chkEstadoAlumno.Checked;

            if (cmbInstrumentoAlumno.SelectedValue != null)
                _alumno.IdInstrumento = (int)cmbInstrumentoAlumno.SelectedValue;

            _repo.ActualizarAlumno(_alumno);
            MessageBox.Show("Alumno actualizado correctamente.");
            this.Close();
        }
    }
}