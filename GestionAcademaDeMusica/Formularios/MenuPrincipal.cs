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
        public MenuPrincipal()
        {
            InitializeComponent();
            InicializarPaneles();
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

        private void btnAlumnos_Click(object sender, EventArgs e)
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
    }
}
