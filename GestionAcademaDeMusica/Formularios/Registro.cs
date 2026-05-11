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
    public partial class Registro : Form
    {
        private readonly AcademiaRepositorio _repo = new AcademiaRepositorio();
        public Registro()
        {
            InitializeComponent();
            picOjo.MouseDown += picOjo_MouseDown;
            picOjo.MouseUp += picOjo_MouseUp;
        }
        private void btnRegistro_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreUsuario.Text) ||
            string.IsNullOrWhiteSpace(txtContraseñaUsuario.Text))
            {
                MessageBox.Show("El nombre y contraseña son obligatorios.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Usuario nuevoUsuario = new Usuario
            {
                NombreUsuario = txtNombreUsuario.Text.Trim(),
                ContraseñaUsuario = txtContraseñaUsuario.Text.Trim()
            };

            _repo.AgregarUsuario(nuevoUsuario);
            MessageBox.Show("Usuario registrado correctamente.");
            this.Close();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void picOjo_MouseDown(object sender, MouseEventArgs e)
        {
            txtContraseñaUsuario.PasswordChar = '\0';
        }
        private void picOjo_MouseUp(object sender, MouseEventArgs e)
        {
            txtContraseñaUsuario.PasswordChar = '●';
        }

        private void Registro_Load(object sender, EventArgs e)
        {
            SendMessage(txtNombreUsuario.Handle, 0x1501, 0, "Registre su nombre");
            SendMessage(txtContraseñaUsuario.Handle, 0x1501, 0, "Registre su contraseña");
        }
        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Unicode)]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, int wParam, string lParam);

        
    }
}
