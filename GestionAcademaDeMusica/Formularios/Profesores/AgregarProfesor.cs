using System;
using System.Windows.Forms;

namespace GestionAcademaDeMusica.Formularios.Profesores
{
    public partial class AgregarProfesor : Form
    {
        private AcademiaRepositorio _repo = new AcademiaRepositorio();

        public AgregarProfesor()
        {
            InitializeComponent();
            btnRegistrarProfe.Click += btnRegistrarProfe_Click;
        }

        private void btnRegistrarProfe_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreAgrProfe.Text) || string.IsNullOrWhiteSpace(txtApellidoAgrProfe.Text))
            {
                MessageBox.Show("El nombre y apellido son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(txtTarifaAgrProfe.Text.Trim(), out decimal tarifa) || tarifa <= 0)
            {
                MessageBox.Show("La tarifa debe ser un número mayor a 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Profesor nuevoProfesor = new Profesor
            {
                NombreProfesor = txtNombreAgrProfe.Text.Trim(),
                ApellidoProfesor = txtApellidoAgrProfe.Text.Trim(),
                TelefonoProfesor = txtTelefonoAgrProfe.Text.Trim(),
                EmailProfesor = txtEmailAgrProfe.Text.Trim(),
                Especialidad = cmbEspecialidadAgrProfe.Text.Trim(),
                TarifaHora = tarifa,
                ActivoProfesor = chkEstadoAgrProfe.Checked
            };

            _repo.AgregarProfesor(nuevoProfesor);
            MessageBox.Show("Profesor agregado exitosamente.");
            this.Close();
        }
    }
}