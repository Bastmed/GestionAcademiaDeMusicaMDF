using GestionAcademaDeMusica.Formularios.Instrumentos;
using System;
using System.Linq;
using System.Windows.Forms;

namespace GestionAcademaDeMusica.Formularios.UserControls
{
    public partial class UCInstrumentos : UserControl
    {
        private readonly AcademiaRepositorio _repo = new AcademiaRepositorio();

        public UCInstrumentos()
        {
            InitializeComponent();
        }

        private void UCInstrumentos_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            dgvInstrumentos.DataSource = null;
            dgvInstrumentos.DataSource = _repo.ObtenerInstrumentos();

            dgvInstrumentos.Columns["IdInstrumento"].Visible = false;

            dgvInstrumentos.Columns["NombreInstrumento"].HeaderText = "Nombre";
            dgvInstrumentos.Columns["Categoria"].HeaderText = "Categoría";
            dgvInstrumentos.Columns["Marca"].HeaderText = "Marca";
            dgvInstrumentos.Columns["Estado"].HeaderText = "Estado";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarInstrumento form = new AgregarInstrumento();
            form.ShowDialog();
            CargarDatos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dgvInstrumentos.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un instrumento de la tabla primero.");
                return;
            }

            Instrumento seleccionado = (Instrumento)dgvInstrumentos.CurrentRow.DataBoundItem;
            ActualizarInstrumento form = new ActualizarInstrumento(seleccionado);
            form.ShowDialog();
            CargarDatos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvInstrumentos.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un instrumento de la tabla primero.");
                return;
            }

            Instrumento seleccionado = (Instrumento)dgvInstrumentos.CurrentRow.DataBoundItem;
            DialogResult confirmacion = MessageBox.Show(
                $"¿Estas seguro de que deseas eliminar el instrumento {seleccionado.NombreInstrumento}?",
                "Confirmar eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmacion == DialogResult.Yes)
            {
                _repo.EliminarInstrumento(seleccionado.IdInstrumento);
                MessageBox.Show("Instrumento eliminado correctamente.");
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

            dgvInstrumentos.DataSource = _repo.ObtenerInstrumentos()
                .Where(i => i.NombreInstrumento.ToLower().Contains(filtro))
                .ToList();

            if (dgvInstrumentos.Columns.Contains("IdInstrumento"))
                dgvInstrumentos.Columns["IdInstrumento"].Visible = false;
        }
    }
}