namespace GestionAcademaDeMusica.Formularios
{
    partial class MenuPrincipal
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
            this.btnAlumnos = new System.Windows.Forms.Button();
            this.btnInstrumentos = new System.Windows.Forms.Button();
            this.btnProfesores = new System.Windows.Forms.Button();
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.pnlIzquierdo = new System.Windows.Forms.Panel();
            this.pnlAlumnos = new System.Windows.Forms.Panel();
            this.pnlInstrumentos = new System.Windows.Forms.Panel();
            this.pnlProfesores = new System.Windows.Forms.Panel();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.picMenuKongeEgg = new System.Windows.Forms.PictureBox();
            this.pnlIzquierdo.SuspendLayout();
            this.pnlContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMenuKongeEgg)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAlumnos
            // 
            this.btnAlumnos.Location = new System.Drawing.Point(16, 23);
            this.btnAlumnos.Name = "btnAlumnos";
            this.btnAlumnos.Size = new System.Drawing.Size(93, 23);
            this.btnAlumnos.TabIndex = 0;
            this.btnAlumnos.Text = "Alumnos";
            this.btnAlumnos.UseVisualStyleBackColor = true;
            this.btnAlumnos.Click += new System.EventHandler(this.btnAlumnos_Click);
            // 
            // btnInstrumentos
            // 
            this.btnInstrumentos.Location = new System.Drawing.Point(16, 79);
            this.btnInstrumentos.Name = "btnInstrumentos";
            this.btnInstrumentos.Size = new System.Drawing.Size(93, 23);
            this.btnInstrumentos.TabIndex = 1;
            this.btnInstrumentos.Text = "Instrumentos";
            this.btnInstrumentos.UseVisualStyleBackColor = true;
            this.btnInstrumentos.Click += new System.EventHandler(this.btnInstrumentos_Click);
            // 
            // btnProfesores
            // 
            this.btnProfesores.Location = new System.Drawing.Point(16, 129);
            this.btnProfesores.Name = "btnProfesores";
            this.btnProfesores.Size = new System.Drawing.Size(93, 23);
            this.btnProfesores.TabIndex = 2;
            this.btnProfesores.Text = "Profesores";
            this.btnProfesores.UseVisualStyleBackColor = true;
            this.btnProfesores.Click += new System.EventHandler(this.btnProfesores_Click);
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(880, 90);
            this.pnlSuperior.TabIndex = 3;
            // 
            // pnlIzquierdo
            // 
            this.pnlIzquierdo.Controls.Add(this.pnlAlumnos);
            this.pnlIzquierdo.Controls.Add(this.pnlInstrumentos);
            this.pnlIzquierdo.Controls.Add(this.pnlProfesores);
            this.pnlIzquierdo.Controls.Add(this.btnInstrumentos);
            this.pnlIzquierdo.Controls.Add(this.btnAlumnos);
            this.pnlIzquierdo.Controls.Add(this.btnProfesores);
            this.pnlIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlIzquierdo.Location = new System.Drawing.Point(0, 90);
            this.pnlIzquierdo.Name = "pnlIzquierdo";
            this.pnlIzquierdo.Size = new System.Drawing.Size(109, 375);
            this.pnlIzquierdo.TabIndex = 4;
            // 
            // pnlAlumnos
            // 
            this.pnlAlumnos.Location = new System.Drawing.Point(0, 23);
            this.pnlAlumnos.Name = "pnlAlumnos";
            this.pnlAlumnos.Size = new System.Drawing.Size(10, 23);
            this.pnlAlumnos.TabIndex = 1;
            // 
            // pnlInstrumentos
            // 
            this.pnlInstrumentos.Location = new System.Drawing.Point(0, 79);
            this.pnlInstrumentos.Name = "pnlInstrumentos";
            this.pnlInstrumentos.Size = new System.Drawing.Size(10, 23);
            this.pnlInstrumentos.TabIndex = 1;
            // 
            // pnlProfesores
            // 
            this.pnlProfesores.Location = new System.Drawing.Point(0, 129);
            this.pnlProfesores.Name = "pnlProfesores";
            this.pnlProfesores.Size = new System.Drawing.Size(10, 23);
            this.pnlProfesores.TabIndex = 2;
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.Controls.Add(this.picMenuKongeEgg);
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(109, 90);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(771, 375);
            this.pnlContenedor.TabIndex = 5;
            // 
            // picMenuKongeEgg
            // 
            this.picMenuKongeEgg.Image = global::GestionAcademaDeMusica.Properties.Resources.epicardo;
            this.picMenuKongeEgg.Location = new System.Drawing.Point(30, 0);
            this.picMenuKongeEgg.Name = "picMenuKongeEgg";
            this.picMenuKongeEgg.Size = new System.Drawing.Size(654, 342);
            this.picMenuKongeEgg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMenuKongeEgg.TabIndex = 0;
            this.picMenuKongeEgg.TabStop = false;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 465);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.pnlIzquierdo);
            this.Controls.Add(this.pnlSuperior);
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.pnlIzquierdo.ResumeLayout(false);
            this.pnlContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picMenuKongeEgg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAlumnos;
        private System.Windows.Forms.Button btnInstrumentos;
        private System.Windows.Forms.Button btnProfesores;
        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.Panel pnlIzquierdo;
        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.Panel pnlAlumnos;
        private System.Windows.Forms.Panel pnlInstrumentos;
        private System.Windows.Forms.Panel pnlProfesores;
        private System.Windows.Forms.PictureBox picMenuKongeEgg;
    }
}