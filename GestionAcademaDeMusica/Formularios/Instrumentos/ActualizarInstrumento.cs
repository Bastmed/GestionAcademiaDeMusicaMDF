using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            _instrumento.NombreInstrumento = txtNombreInstrumento.Text.Trim();
            _instrumento.Marca = txtMarcaInstrumento.Text.Trim();
            _instrumento.Categoria = cmbCategoriaInstrumento.SelectedItem?.ToString();
            _instrumento.Estado = cmbEstadoInstrumento.SelectedItem?.ToString();

            _repo.ActualizarInstrumento(_instrumento);
            MessageBox.Show("Instrumento actualizado correctamente.");
            this.Close();
        }
    }
}
