using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionAcademaDeMusica.Formularios.Alumnos
{
    public partial class AgregarAlumno : Form
    {
        private AcademiaRepositorio _repo = new AcademiaRepositorio();
        public AgregarAlumno()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreAlumno.Text) || string.IsNullOrWhiteSpace(txtApellidoAlumno.Text))
            {
                MessageBox.Show("El nombre y apellido son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Alumno nuevoAlumno = new Alumno
            {
                NombreAlumno = txtNombreAlumno.Text.Trim(),
                ApellidoAlumno = txtApellidoAlumno.Text.Trim(),
                FechaNacimiento = dtpFechaAlumno.Value,
                TelefonoAlumno = txtTelefonoAlumno.Text.Trim(),
                EmailAlumno = txtEmailAlumno.Text.Trim(),
                ActivoAlumno = chkEstadoAlumno.Checked,
                IdInstrumento = null

            };

            _repo.AgregarAlumno(nuevoAlumno);
            MessageBox.Show("Alumno agregado exitosamente.");
            this.Close();
        }

    }
}
