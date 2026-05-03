using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionAcademaDeMusica.Formularios.UserControls
{
    public partial class UCAlumnos : UserControl
    {
        private readonly AcademiaRepositorio _repo = new AcademiaRepositorio();

        public UCAlumnos()
        {
            InitializeComponent();
        }

        private void UCAlumnos_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            dgvAlumnos.DataSource = null;
            dgvAlumnos.DataSource = _repo.ObtenerAlumnos();

            dgvAlumnos.Columns["IdAlumno"].Visible = false;
            dgvAlumnos.Columns["IdInstrumento"].Visible = false;

            dgvAlumnos.Columns["NombreAlumno"].HeaderText = "Nombre";
            dgvAlumnos.Columns["ApellidoAlumno"].HeaderText = "Apellido";
            dgvAlumnos.Columns["FechaNacimiento"].HeaderText = "Fecha Nac.";
            dgvAlumnos.Columns["TelefonoAlumno"].HeaderText = "Teléfono";
            dgvAlumnos.Columns["EmailAlumno"].HeaderText = "Email";
            dgvAlumnos.Columns["ActivoAlumno"].HeaderText = "Activo";
        }
    }
}
