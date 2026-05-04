using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreInstrumento.Text) || string.IsNullOrWhiteSpace(txtMarcaInstrumento.Text))
            {
                MessageBox.Show("El nombre y la marca son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Instrumento nuevoInstrumento = new Instrumento
            {
                NombreInstrumento = txtNombreInstrumento.Text.Trim(),
                Marca = txtMarcaInstrumento.Text.Trim(),
                Categoria = cmbCategoriaInstrumento.SelectedItem?.ToString(),
                Estado = cmbEstadoInstrumento.SelectedItem?.ToString()
            };

            _repo.AgregarInstrumento(nuevoInstrumento);
            MessageBox.Show("Instrumento agregado exitosamente.");
            this.Close();
        }
    }
}
