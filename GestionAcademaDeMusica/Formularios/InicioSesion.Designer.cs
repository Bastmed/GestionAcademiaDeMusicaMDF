namespace GestionAcademaDeMusica.Formularios
{
    partial class InicioSesion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblInicioSesion = new System.Windows.Forms.Label();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.lblContraseñaUsuario = new System.Windows.Forms.Label();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseñaUsuario = new System.Windows.Forms.TextBox();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInicioSesion
            // 
            this.lblInicioSesion.AutoSize = true;
            this.lblInicioSesion.Location = new System.Drawing.Point(366, 38);
            this.lblInicioSesion.Name = "lblInicioSesion";
            this.lblInicioSesion.Size = new System.Drawing.Size(80, 13);
            this.lblInicioSesion.TabIndex = 0;
            this.lblInicioSesion.Text = "Inicio de sesión";
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Location = new System.Drawing.Point(272, 107);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(47, 13);
            this.lblNombreUsuario.TabIndex = 1;
            this.lblNombreUsuario.Text = "Nombre:";
            // 
            // lblContraseñaUsuario
            // 
            this.lblContraseñaUsuario.AutoSize = true;
            this.lblContraseñaUsuario.Location = new System.Drawing.Point(272, 185);
            this.lblContraseñaUsuario.Name = "lblContraseñaUsuario";
            this.lblContraseñaUsuario.Size = new System.Drawing.Size(64, 13);
            this.lblContraseñaUsuario.TabIndex = 2;
            this.lblContraseñaUsuario.Text = "Contraseña:";
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(422, 107);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtNombreUsuario.TabIndex = 3;
            // 
            // txtContraseñaUsuario
            // 
            this.txtContraseñaUsuario.Location = new System.Drawing.Point(422, 178);
            this.txtContraseñaUsuario.Name = "txtContraseñaUsuario";
            this.txtContraseñaUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtContraseñaUsuario.TabIndex = 4;
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.Location = new System.Drawing.Point(369, 265);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(103, 23);
            this.btnIniciarSesion.TabIndex = 5;
            this.btnIniciarSesion.Text = "Iniciar sesión";
            this.btnIniciarSesion.UseVisualStyleBackColor = true;

            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // InicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIniciarSesion);
            this.Controls.Add(this.txtContraseñaUsuario);
            this.Controls.Add(this.txtNombreUsuario);
            this.Controls.Add(this.lblContraseñaUsuario);
            this.Controls.Add(this.lblNombreUsuario);
            this.Controls.Add(this.lblInicioSesion);
            this.Name = "InicioSesion";
            this.Text = "InicioSesion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInicioSesion;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Label lblContraseñaUsuario;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.TextBox txtContraseñaUsuario;
        private System.Windows.Forms.Button btnIniciarSesion;
    }
}