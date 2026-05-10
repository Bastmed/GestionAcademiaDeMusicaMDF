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
            this.btnInstrumentos = new System.Windows.Forms.Button();
            this.btnProfesores = new System.Windows.Forms.Button();
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.pnlIzquierdo = new System.Windows.Forms.Panel();
            this.pnlAlumnos = new System.Windows.Forms.Panel();
            this.pnlInstrumentos = new System.Windows.Forms.Panel();
            this.pnlProfesores = new System.Windows.Forms.Panel();
            this.btn = new System.Windows.Forms.Button();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.picMenuKongeEgg = new System.Windows.Forms.PictureBox();
            this.pnlIzquierdo.SuspendLayout();
            this.pnlContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMenuKongeEgg)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInstrumentos
            // 
            this.btnInstrumentos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btnInstrumentos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInstrumentos.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnInstrumentos.FlatAppearance.BorderSize = 2;
            this.btnInstrumentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInstrumentos.Font = new System.Drawing.Font("Roboto SemiCondensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstrumentos.ForeColor = System.Drawing.Color.White;
            this.btnInstrumentos.Location = new System.Drawing.Point(16, 87);
            this.btnInstrumentos.Name = "btnInstrumentos";
            this.btnInstrumentos.Size = new System.Drawing.Size(117, 31);
            this.btnInstrumentos.TabIndex = 1;
            this.btnInstrumentos.Text = "Instrumentos";
            this.btnInstrumentos.UseVisualStyleBackColor = false;
            this.btnInstrumentos.Click += new System.EventHandler(this.btnInstrumentos_Click);
            // 
            // btnProfesores
            // 
            this.btnProfesores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btnProfesores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfesores.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnProfesores.FlatAppearance.BorderSize = 2;
            this.btnProfesores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfesores.Font = new System.Drawing.Font("Roboto SemiCondensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfesores.ForeColor = System.Drawing.Color.White;
            this.btnProfesores.Location = new System.Drawing.Point(16, 137);
            this.btnProfesores.Name = "btnProfesores";
            this.btnProfesores.Size = new System.Drawing.Size(117, 31);
            this.btnProfesores.TabIndex = 2;
            this.btnProfesores.Text = "Profesores";
            this.btnProfesores.UseVisualStyleBackColor = false;
            this.btnProfesores.Click += new System.EventHandler(this.btnProfesores_Click);
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(1104, 90);
            this.pnlSuperior.TabIndex = 3;
            // 
            // pnlIzquierdo
            // 
            this.pnlIzquierdo.Controls.Add(this.pnlAlumnos);
            this.pnlIzquierdo.Controls.Add(this.pnlInstrumentos);
            this.pnlIzquierdo.Controls.Add(this.pnlProfesores);
            this.pnlIzquierdo.Controls.Add(this.btnInstrumentos);
            this.pnlIzquierdo.Controls.Add(this.btn);
            this.pnlIzquierdo.Controls.Add(this.btnProfesores);
            this.pnlIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlIzquierdo.Location = new System.Drawing.Point(0, 90);
            this.pnlIzquierdo.Name = "pnlIzquierdo";
            this.pnlIzquierdo.Size = new System.Drawing.Size(133, 521);
            this.pnlIzquierdo.TabIndex = 4;
            // 
            // pnlAlumnos
            // 
            this.pnlAlumnos.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.pnlAlumnos.Location = new System.Drawing.Point(0, 31);
            this.pnlAlumnos.Name = "pnlAlumnos";
            this.pnlAlumnos.Size = new System.Drawing.Size(10, 31);
            this.pnlAlumnos.TabIndex = 1;
            // 
            // pnlInstrumentos
            // 
            this.pnlInstrumentos.BackColor = System.Drawing.Color.RoyalBlue;
            this.pnlInstrumentos.Location = new System.Drawing.Point(0, 87);
            this.pnlInstrumentos.Name = "pnlInstrumentos";
            this.pnlInstrumentos.Size = new System.Drawing.Size(10, 31);
            this.pnlInstrumentos.TabIndex = 1;
            // 
            // pnlProfesores
            // 
            this.pnlProfesores.BackColor = System.Drawing.Color.DarkGray;
            this.pnlProfesores.Location = new System.Drawing.Point(0, 137);
            this.pnlProfesores.Name = "pnlProfesores";
            this.pnlProfesores.Size = new System.Drawing.Size(10, 31);
            this.pnlProfesores.TabIndex = 2;
            // 
            // btn
            // 
            this.btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.btn.FlatAppearance.BorderSize = 2;
            this.btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn.Font = new System.Drawing.Font("Roboto SemiCondensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn.ForeColor = System.Drawing.Color.White;
            this.btn.Location = new System.Drawing.Point(16, 31);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(117, 31);
            this.btn.TabIndex = 0;
            this.btn.Text = "Alumnos";
            this.btn.UseVisualStyleBackColor = false;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.Controls.Add(this.picMenuKongeEgg);
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(133, 90);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(971, 521);
            this.pnlContenedor.TabIndex = 5;
            // 
            // picMenuKongeEgg
            // 
            this.picMenuKongeEgg.Image = global::GestionAcademaDeMusica.Properties.Resources.epicardo;
            this.picMenuKongeEgg.Location = new System.Drawing.Point(0, 0);
            this.picMenuKongeEgg.Name = "picMenuKongeEgg";
            this.picMenuKongeEgg.Size = new System.Drawing.Size(971, 521);
            this.picMenuKongeEgg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMenuKongeEgg.TabIndex = 0;
            this.picMenuKongeEgg.TabStop = false;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1104, 611);
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
        private System.Windows.Forms.Button btnInstrumentos;
        private System.Windows.Forms.Button btnProfesores;
        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.Panel pnlIzquierdo;
        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.Panel pnlAlumnos;
        private System.Windows.Forms.Panel pnlInstrumentos;
        private System.Windows.Forms.Panel pnlProfesores;
        private System.Windows.Forms.PictureBox picMenuKongeEgg;
        private System.Windows.Forms.Button btn;
    }
}