using System;
using System.Windows.Forms;

namespace GestionAcademaDeMusica.Formularios.Instrumentos
{
    public partial class ActualizarInstrumento : Form
    {
        private AcademiaRepositorio _repo = new AcademiaRepositorio();
        private Instrumento _instrumento;

        public ActualizarInstrumento(Instrumento seleccionado)
        {
            InitializeComponent();
            _instrumento = seleccionado;
        }

        private void ActualizarInstrumento_Load(object sender, EventArgs e)
        {
            txtNombreInstrumento.Text = _instrumento.NombreInstrumento;
            txtMarcaInstrumento.Text = _instrumento.Marca;
            cmbCategoriaInstrumento.SelectedItem = _instrumento.Categoria;
            cmbEstadoInstrumento.SelectedItem = _instrumento.Estado;
        }

        private void btnActu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreInstrumento.Text))
            {
                MessageBox.Show("El nombre es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtMarcaInstrumento.Text))
            {
                MessageBox.Show("La marca es obligatoria.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cmbCategoriaInstrumento.SelectedIndex == -1)
            {
                MessageBox.Show("Debes seleccionar una categoría.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cmbEstadoInstrumento.SelectedIndex == -1)
            {
                MessageBox.Show("Debes seleccionar un estado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _instrumento.NombreInstrumento = txtNombreInstrumento.Text.Trim();
            _instrumento.Marca = txtMarcaInstrumento.Text.Trim();
            _instrumento.Categoria = cmbCategoriaInstrumento.SelectedItem.ToString();
            _instrumento.Estado = cmbEstadoInstrumento.SelectedItem.ToString();

            _repo.ActualizarInstrumento(_instrumento);
            MessageBox.Show("Instrumento actualizado correctamente.");
            this.Close();
        }
    }
}