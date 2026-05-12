using System;
using System.Windows.Forms;

namespace GestionAcademaDeMusica
{
    public partial class AgregarInstrumento : Form
    {
        private AcademiaRepositorio _repo = new AcademiaRepositorio();

        public AgregarInstrumento()
        {
            InitializeComponent();
        }

        private void btnGuar_Click(object sender, EventArgs e)
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

            Instrumento nuevoInstrumento = new Instrumento
            {
                NombreInstrumento = txtNombreInstrumento.Text.Trim(),
                Marca = txtMarcaInstrumento.Text.Trim(),
                Categoria = cmbCategoriaInstrumento.SelectedItem.ToString(),
                Estado = cmbEstadoInstrumento.SelectedItem.ToString()
            };

            _repo.AgregarInstrumento(nuevoInstrumento);
            MessageBox.Show("Instrumento agregado exitosamente.");
            this.Close();
        }
    }
}