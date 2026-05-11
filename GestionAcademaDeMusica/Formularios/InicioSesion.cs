using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace GestionAcademaDeMusica.Formularios
{
    public partial class InicioSesion : Form
    {
        private readonly AcademiaRepositorio _repo = new AcademiaRepositorio();
        public InicioSesion()
        {
            InitializeComponent();
            picOjo.MouseDown += picOjo_MouseDown;
            picOjo.MouseUp += picOjo_MouseUp;
        }

        private void picOjo_MouseDown(object sender, MouseEventArgs e)
        {
            txtContraseñaUsuario.PasswordChar = '\0';
        }
        private void picOjo_MouseUp(object sender, MouseEventArgs e)
        {
            txtContraseñaUsuario.PasswordChar = '●';
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            Usuario usuario = _repo.ValidarUsuario(txtNombreUsuario.Text, txtContraseñaUsuario.Text);

            if (usuario != null)
            {
                MenuPrincipal menu = new MenuPrincipal(usuario.NombreUsuario);
                MessageBox.Show($"Inicio de sesión exitoso, Bienvenido {usuario.NombreUsuario}");
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombreUsuario.Clear();
                txtContraseñaUsuario.Clear();
            }
        }

        private void InicioSesion_Load(object sender, EventArgs e)
        {
            SendMessage(txtNombreUsuario.Handle, 0x1501, 0, "Ingrese su nombre");
            SendMessage(txtContraseñaUsuario.Handle, 0x1501, 0, "Ingrese su contraseña");


        }
        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Unicode)]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, int wParam, string lParam);

        private void linklblRegistro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registro formRegistro = new Registro();
            formRegistro.ShowDialog();
        }

    }

}
