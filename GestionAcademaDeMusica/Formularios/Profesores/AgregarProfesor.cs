using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace GestionAcademaDeMusica.Formularios.Profesores
{
    public partial class AgregarProfesor : Form
    {
        private AcademiaRepositorio _repo = new AcademiaRepositorio();

        public AgregarProfesor()
        {
            InitializeComponent();
            btnRegistrarProfe.Click += btnRegistrarProfe_Click;
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

        private void btnRegistrarProfe_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreAgrProfe.Text) || string.IsNullOrWhiteSpace(txtApellidoAgrProfe.Text))
            {
                MessageBox.Show("El nombre y apellido son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(txtTarifaAgrProfe.Text.Trim(), out decimal tarifa) || tarifa <= 0)
            {
                MessageBox.Show("La tarifa debe ser un número mayor a 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!string.IsNullOrWhiteSpace(txtEmailAgrProfe.Text) &&
                !EmailValido(txtEmailAgrProfe.Text.Trim()))
            {
                MessageBox.Show("El email ingresado no es valido.\nejemplo: usuario@gmail.com", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!string.IsNullOrWhiteSpace(txtTelefonoAgrProfe.Text) &&
                !TelefonoValido(txtTelefonoAgrProfe.Text.Trim()))
            {
                MessageBox.Show("El telefono no es válido.\nejemplo: +56 9 1234 5678", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Profesor nuevoProfesor = new Profesor
            {
                NombreProfesor = txtNombreAgrProfe.Text.Trim(),
                ApellidoProfesor = txtApellidoAgrProfe.Text.Trim(),
                TelefonoProfesor = txtTelefonoAgrProfe.Text.Trim(),
                EmailProfesor = txtEmailAgrProfe.Text.Trim(),
                Especialidad = cmbEspecialidadAgrProfe.Text.Trim(),
                TarifaHora = tarifa,
                ActivoProfesor = chkEstadoAgrProfe.Checked
            };

            _repo.AgregarProfesor(nuevoProfesor);
            MessageBox.Show("Profesor agregado exitosamente.");
            this.Close();
        }
    }
}