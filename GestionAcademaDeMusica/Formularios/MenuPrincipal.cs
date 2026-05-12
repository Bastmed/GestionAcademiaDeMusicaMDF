using GestionAcademaDeMusica.Formularios.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionAcademaDeMusica.Formularios
{
    public partial class MenuPrincipal : Form
    {
        private UCAlumnos ucAlumnos = new UCAlumnos();
        private UCInstrumentos ucInstrumentos = new UCInstrumentos();
        private UCProfesores ucProfesores = new UCProfesores();
        private readonly AcademiaRepositorio _repo = new AcademiaRepositorio();
        public MenuPrincipal(string nombreUsuario)
        {
            InitializeComponent();
            InicializarPaneles();
            lblUsuario.Text = "Usuario: " + nombreUsuario;
        }

        private void InicializarPaneles()
        {
            ucAlumnos.Dock = DockStyle.Fill;
            ucInstrumentos.Dock = DockStyle.Fill;
            ucProfesores.Dock = DockStyle.Fill;
        }

        private void MostrarPanel(UserControl control)
        {
            pnlContenedor.Controls.Clear();
            pnlContenedor.Controls.Add(control);
        }

        private void btn_Click(object sender, EventArgs e)
        {
            MostrarPanel(ucAlumnos);
        }

        private void btnInstrumentos_Click(object sender, EventArgs e)
        {
            MostrarPanel(ucInstrumentos);
        }

        private void btnProfesores_Click(object sender, EventArgs e)
        {
            MostrarPanel(ucProfesores);
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            lblFecha.Text = "Fecha: " + DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult confirmacion = MessageBox.Show($"¿Deseas cerrar sesión con el {lblUsuario.Text}?", "Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                InicioSesion login = new InicioSesion();
                login.Show();
                this.Close();
            }
        }
    }
}
