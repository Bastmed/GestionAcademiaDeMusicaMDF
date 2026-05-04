using GestionAcademaDeMusica.Formularios.Profesores;
using System;
using System.Windows.Forms;

namespace GestionAcademaDeMusica
{
    public partial class UCProfesores : UserControl
    {
        private readonly AcademiaRepositorio _repo = new AcademiaRepositorio();

        public UCProfesores()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void UCProfesores_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            dgvProfesores.DataSource = null;
            dgvProfesores.DataSource = _repo.ObtenerProfesores();

            dgvProfesores.Columns["IdProfesor"].Visible = false;

            dgvProfesores.Columns["NombreProfesor"].HeaderText = "Nombre";
            dgvProfesores.Columns["ApellidoProfesor"].HeaderText = "Apellido";
            dgvProfesores.Columns["TelefonoProfesor"].HeaderText = "Teléfono";
            dgvProfesores.Columns["EmailProfesor"].HeaderText = "Email";
            dgvProfesores.Columns["Especialidad"].HeaderText = "Especialidad";
            dgvProfesores.Columns["TarifaHora"].HeaderText = "Tarifa/Hora";
            dgvProfesores.Columns["TarifaConIVA"].HeaderText = "Tarifa con IVA";
            dgvProfesores.Columns["ActivoProfesor"].HeaderText = "Activo";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarProfesor form = new AgregarProfesor();
            form.ShowDialog();
            CargarDatos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dgvProfesores.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un profesor de la tabla primero.");
                return;
            }

            Profesor seleccionado = (Profesor)dgvProfesores.CurrentRow.DataBoundItem;
            ActualizarProfesor form = new ActualizarProfesor(seleccionado);
            form.ShowDialog();
            CargarDatos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvProfesores.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un profesor de la tabla primero.");
                return;
            }

            Profesor seleccionado = (Profesor)dgvProfesores.CurrentRow.DataBoundItem;
            DialogResult confirmacion = MessageBox.Show(
                $"¿Estás seguro de eliminar al profesor {seleccionado.NombreProfesor} {seleccionado.ApellidoProfesor}?",
                "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmacion == DialogResult.Yes)
            {
                _repo.EliminarProfesor(seleccionado.IdProfesor);
                MessageBox.Show("Profesor eliminado correctamente.");
                CargarDatos();
            }
        }
    }
}