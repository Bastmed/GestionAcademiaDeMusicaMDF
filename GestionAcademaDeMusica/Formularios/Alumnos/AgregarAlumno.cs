using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace GestionAcademaDeMusica.Formularios.Alumnos
{
    public partial class AgregarAlumno : Form
    {
        private AcademiaRepositorio _repo = new AcademiaRepositorio();

        public AgregarAlumno()
        {
            InitializeComponent();

            cmbInstrumentoAlumno.DisplayMember = "NombreInstrumento";
            cmbInstrumentoAlumno.ValueMember = "IdInstrumento";
            cmbInstrumentoAlumno.DataSource = _repo.ObtenerInstrumentos();
        }
        private bool EmailValido(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private bool TelefonoValido(string telefono)
        {
            string limpio = Regex.Replace(telefono.Trim(), @"[\s\-]", "");
            string patron = @"^\+?[1-9]\d{7,14}$";
            return Regex.IsMatch(limpio, patron);
        }

        private void btnGuar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreAlumno.Text) || string.IsNullOrWhiteSpace(txtApellidoAlumno.Text))
            {
                MessageBox.Show("El nombre y apellido son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!string.IsNullOrWhiteSpace(txtEmailAlumno.Text) &&
                !EmailValido(txtEmailAlumno.Text.Trim()))
            {
                MessageBox.Show("El email ingresado no es valido.\nejemplo: usuario@gmail.com", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!string.IsNullOrWhiteSpace(txtTelefonoAlumno.Text) &&
                !TelefonoValido(txtTelefonoAlumno.Text.Trim()))
            {
                MessageBox.Show("El telefono no es válido.\nejemplo: +56 9 1234 5678", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int? idInstrumento = null;
            if (cmbInstrumentoAlumno.SelectedValue != null)
                idInstrumento = (int)cmbInstrumentoAlumno.SelectedValue;

            Alumno nuevoAlumno = new Alumno
            {
                NombreAlumno = txtNombreAlumno.Text.Trim(),
                ApellidoAlumno = txtApellidoAlumno.Text.Trim(),
                FechaNacimiento = dtpFechaAlumno.Value,
                TelefonoAlumno = txtTelefonoAlumno.Text.Trim(),
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