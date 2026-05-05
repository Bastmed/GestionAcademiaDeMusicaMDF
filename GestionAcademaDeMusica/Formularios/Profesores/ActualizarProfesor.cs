using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace GestionAcademaDeMusica.Formularios.Profesores
{
    public partial class ActualizarProfesor : Form
    {
        private AcademiaRepositorio _repo = new AcademiaRepositorio();
        private Profesor _profesor;

        public ActualizarProfesor(Profesor seleccionado)
        {
            InitializeComponent();
            _profesor = seleccionado;
            btnActualizarProfe.Click += btnActualizarProfe_Click;
            this.Load += ActualizarProfesor_Load;
        }

        private void ActualizarProfesor_Load(object sender, EventArgs e)
        {
            txtNombreActProfe.Text = _profesor.NombreProfesor;
            txtApellidoActProfe.Text = _profesor.ApellidoProfesor;
            txtTelefonoActProfe.Text = _profesor.TelefonoProfesor;
            txtEmailActProfe.Text = _profesor.EmailProfesor;
            cmbEspecialidadActProfe.Text = _profesor.Especialidad;
            txtTarifaActProfe.Text = _profesor.TarifaHora.ToString();
            chkEstadoActProfe.Checked = _profesor.ActivoProfesor;
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

        private void btnActualizarProfe_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreActProfe.Text) || string.IsNullOrWhiteSpace(txtApellidoActProfe.Text))
            {
                MessageBox.Show("El nombre y apellido son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(txtTarifaActProfe.Text.Trim(), out decimal tarifa) || tarifa <= 0)
            {
                MessageBox.Show("La tarifa debe ser un número mayor a 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!string.IsNullOrWhiteSpace(txtEmailActProfe.Text) &&
                !EmailValido(txtEmailActProfe.Text.Trim()))
            {
                MessageBox.Show("El email ingresado no es valido.\nejemplo: usuario@gmail.com", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!string.IsNullOrWhiteSpace(txtTelefonoActProfe.Text) &&
                !TelefonoValido(txtTelefonoActProfe.Text.Trim()))
            {
                MessageBox.Show("El telefono no es válido.\nejemplo: +56 9 1234 5678", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _profesor.NombreProfesor = txtNombreActProfe.Text.Trim();
            _profesor.ApellidoProfesor = txtApellidoActProfe.Text.Trim();
            _profesor.TelefonoProfesor = txtTelefonoActProfe.Text.Trim();
            _profesor.EmailProfesor = txtEmailActProfe.Text.Trim();
            _profesor.Especialidad = cmbEspecialidadActProfe.Text.Trim();
            _profesor.TarifaHora = tarifa;
            _profesor.ActivoProfesor = chkEstadoActProfe.Checked;

            _repo.ActualizarProfesor(_profesor);
            MessageBox.Show("Profesor actualizado correctamente.");
            this.Close();
        }
    }
}