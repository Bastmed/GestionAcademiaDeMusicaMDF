using GestionAcademaDeMusica.Formularios.Alumnos;
using System;
using System.Linq;
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarAlumno form = new AgregarAlumno();
            form.ShowDialog();
            CargarDatos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dgvAlumnos.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un alumno de la tabla primero.");
                return;
            }

            Alumno seleccionado = (Alumno)dgvAlumnos.CurrentRow.DataBoundItem;
            ActualizarAlumno form = new ActualizarAlumno(seleccionado);
            form.ShowDialog();
            CargarDatos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvAlumnos.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un alumno de la tabla primero.");
                return;
            }

            Alumno seleccionado = (Alumno)dgvAlumnos.CurrentRow.DataBoundItem;
            DialogResult confirmacion = MessageBox.Show(
                $"¿Estas seguro de que deseas eliminar al alumno {seleccionado.NombreAlumno} {seleccionado.ApellidoAlumno}?",
                "Confirmar eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmacion == DialogResult.Yes)
            {
                _repo.EliminarAlumno(seleccionado.IdAlumno);
                MessageBox.Show("Alumno eliminado correctamente.");
                CargarDatos();
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBuscar.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(filtro))
            {
                CargarDatos();
                return;
            }

            dgvAlumnos.DataSource = _repo.ObtenerAlumnos()
                .Where(a => a.NombreAlumno.ToLower().Contains(filtro))
                .ToList();

            if (dgvAlumnos.Columns.Contains("IdAlumno"))
                dgvAlumnos.Columns["IdAlumno"].Visible = false;
            if (dgvAlumnos.Columns.Contains("IdInstrumento"))
                dgvAlumnos.Columns["IdInstrumento"].Visible = false;
        }
    }
}