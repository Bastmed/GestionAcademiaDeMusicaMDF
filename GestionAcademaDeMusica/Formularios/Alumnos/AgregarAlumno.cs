using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GestionAcademaDeMusica.Formularios.Alumnos
{
    public partial class AgregarAlumno : Form
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

        public AgregarAlumno()
        {
            InitializeComponent();

            cmbTelefonoAgrAlumno.Items.AddRange(PrefijosLatam);
            cmbTelefonoAgrAlumno.SelectedIndex = 3; // Chile por defecto

            cmbInstrumentoAlumno.DisplayMember = "NombreInstrumento";
            cmbInstrumentoAlumno.ValueMember = "IdInstrumento";
            cmbInstrumentoAlumno.DataSource = _repo.ObtenerInstrumentos();
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

        private void btnGuar_Click(object sender, EventArgs e)
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
                string prefijo = cmbTelefonoAgrAlumno.SelectedItem?.ToString().Split(' ')[0] ?? "";
                telefonoFinal = prefijo + " " + txtTelefonoAlumno.Text.Trim();
            }

            int? idInstrumento = null;
            if (cmbInstrumentoAlumno.SelectedValue != null)
                idInstrumento = (int)cmbInstrumentoAlumno.SelectedValue;

            Alumno nuevoAlumno = new Alumno
            {
                NombreAlumno = txtNombreAlumno.Text.Trim(),
                ApellidoAlumno = txtApellidoAlumno.Text.Trim(),
                FechaNacimiento = dtpFechaAlumno.Value,
                TelefonoAlumno = telefonoFinal,
                EmailAlumno = txtEmailAlumno.Text.Trim(),
                ActivoAlumno = chkEstadoAlumno.Checked,
                IdInstrumento = idInstrumento
            };

            _repo.AgregarAlumno(nuevoAlumno);
            MessageBox.Show("Alumno agregado exitosamente.");
            this.Close();
        }

    }
}