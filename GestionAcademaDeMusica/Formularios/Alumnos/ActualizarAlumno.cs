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
    
    public partial class ActualizarAlumno : Form
    {
        private AcademiaRepositorio _repo = new AcademiaRepositorio();
        private Alumno _alumno;

        public ActualizarAlumno(Alumno seleccionado)
        {
            InitializeComponent();
            _alumno = seleccionado;
        }

        private void ActualizarAlumno_Load(object sender, EventArgs e)
        {
            txtNombreAlumno.Text = _alumno.NombreAlumno;
            txtApellidoAlumno.Text = _alumno.ApellidoAlumno;
            dtpFechaAlumno.Value = _alumno.FechaNacimiento;
            txtTelefonoAlumno.Text = _alumno.TelefonoAlumno;
            txtEmailAlumno.Text = _alumno.EmailAlumno;
            chkEstadoAlumno.Checked = _alumno.ActivoAlumno;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            _alumno.NombreAlumno = txtNombreAlumno.Text.Trim();
            _alumno.ApellidoAlumno = txtApellidoAlumno.Text.Trim();
            _alumno.FechaNacimiento = dtpFechaAlumno.Value;
            _alumno.TelefonoAlumno = txtTelefonoAlumno.Text.Trim();
            _alumno.EmailAlumno = txtEmailAlumno.Text.Trim();
            _alumno.ActivoAlumno = chkEstadoAlumno.Checked;

            _repo.ActualizarAlumno(_alumno);
            MessageBox.Show("Alumno actualizado correctamente.");
            this.Close();
        }
    }
}
