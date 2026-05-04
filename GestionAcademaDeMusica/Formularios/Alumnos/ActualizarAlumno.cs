using System;
using System.Windows.Forms;

namespace GestionAcademaDeMusica.Formularios.Alumnos
{
    public partial class ActualizarAlumno : Form
    {
        private AcademiaRepositorio _repo = new AcademiaRepositorio();
        private Alumno _alumno;

        public ActualizarAlumno(Alumno seleccionado)
        {
            InitializeComponent();
            _alumno = seleccionado;

            cmbInstrumentoAlumno.DisplayMember = "NombreInstrumento";
            cmbInstrumentoAlumno.ValueMember   = "IdInstrumento";
            cmbInstrumentoAlumno.DataSource    = _repo.ObtenerInstrumentos();
        }

        private void ActualizarAlumno_Load(object sender, EventArgs e)
        {
            txtNombreAlumno.Text    = _alumno.NombreAlumno;
            txtApellidoAlumno.Text  = _alumno.ApellidoAlumno;
            dtpFechaAlumno.Value    = _alumno.FechaNacimiento;
            txtTelefonoAlumno.Text  = _alumno.TelefonoAlumno;
            txtEmailAlumno.Text     = _alumno.EmailAlumno;
            chkEstadoAlumno.Checked = _alumno.ActivoAlumno;

            if (_alumno.IdInstrumento != null)
                cmbInstrumentoAlumno.SelectedValue = _alumno.IdInstrumento;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreAlumno.Text) || string.IsNullOrWhiteSpace(txtApellidoAlumno.Text))
            {
                MessageBox.Show("El nombre y apellido son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _alumno.NombreAlumno    = txtNombreAlumno.Text.Trim();
            _alumno.ApellidoAlumno  = txtApellidoAlumno.Text.Trim();
            _alumno.FechaNacimiento = dtpFechaAlumno.Value;
            _alumno.TelefonoAlumno  = txtTelefonoAlumno.Text.Trim();
            _alumno.EmailAlumno     = txtEmailAlumno.Text.Trim();
            _alumno.ActivoAlumno    = chkEstadoAlumno.Checked;

            if (cmbInstrumentoAlumno.SelectedValue != null)
                _alumno.IdInstrumento = (int)cmbInstrumentoAlumno.SelectedValue;

            _repo.ActualizarAlumno(_alumno);
            MessageBox.Show("Alumno actualizado correctamente.");
            this.Close();
        }
    }
}