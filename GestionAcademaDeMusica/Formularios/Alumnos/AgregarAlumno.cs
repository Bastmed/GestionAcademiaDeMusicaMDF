using System;
using System.Collections.Generic;
using System.Windows.Forms;

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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreAlumno.Text) || string.IsNullOrWhiteSpace(txtApellidoAlumno.Text))
            {
                MessageBox.Show("El nombre y apellido son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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