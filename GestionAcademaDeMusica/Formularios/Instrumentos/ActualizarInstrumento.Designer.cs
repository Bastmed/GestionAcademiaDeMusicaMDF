namespace GestionAcademaDeMusica.Formularios.Instrumentos
{
    partial class ActualizarInstrumento
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
            this.cmbEstadoInstrumento = new System.Windows.Forms.ComboBox();
            this.cmbCategoriaInstrumento = new System.Windows.Forms.ComboBox();
            this.txtMarcaInstrumento = new System.Windows.Forms.TextBox();
            this.lblEstadoInstrumento = new System.Windows.Forms.Label();
            this.lblMarcaInstrumento = new System.Windows.Forms.Label();
            this.txtNombreInstrumento = new System.Windows.Forms.TextBox();
            this.lblCategoriaInstrumento = new System.Windows.Forms.Label();
            this.lblNombreInstrumento = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnActu = new GestionAcademaDeMusica.Model.BotonRedondo();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbEstadoInstrumento
            // 
            this.cmbEstadoInstrumento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.cmbEstadoInstrumento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbEstadoInstrumento.Font = new System.Drawing.Font("Roboto SemiCondensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstadoInstrumento.ForeColor = System.Drawing.Color.White;
            this.cmbEstadoInstrumento.FormattingEnabled = true;
            this.cmbEstadoInstrumento.Items.AddRange(new object[] {
            "Disponible",
            "En uso",
            "En mantenimiento",
            "Deteriorado",
            "De baja"});
            this.cmbEstadoInstrumento.Location = new System.Drawing.Point(486, 185);
            this.cmbEstadoInstrumento.Name = "cmbEstadoInstrumento";
            this.cmbEstadoInstrumento.Size = new System.Drawing.Size(121, 22);
            this.cmbEstadoInstrumento.TabIndex = 32;
            // 
            // cmbCategoriaInstrumento
            // 
            this.cmbCategoriaInstrumento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.cmbCategoriaInstrumento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCategoriaInstrumento.Font = new System.Drawing.Font("Roboto SemiCondensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategoriaInstrumento.ForeColor = System.Drawing.Color.White;
            this.cmbCategoriaInstrumento.FormattingEnabled = true;
            this.cmbCategoriaInstrumento.Items.AddRange(new object[] {
            "Cuerda Frotada",
            "Cuerda Pulsada",
            "Cuerda Percutida",
            "Viento Madera",
            "Viento Metal",
            "Percusión",
            "Teclas",
            "Electrónico",
            "Folclórico"});
            this.cmbCategoriaInstrumento.Location = new System.Drawing.Point(93, 185);
            this.cmbCategoriaInstrumento.Name = "cmbCategoriaInstrumento";
            this.cmbCategoriaInstrumento.Size = new System.Drawing.Size(121, 22);
            this.cmbCategoriaInstrumento.TabIndex = 30;
            // 
            // txtMarcaInstrumento
            // 
            this.txtMarcaInstrumento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.txtMarcaInstrumento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMarcaInstrumento.Font = new System.Drawing.Font("Roboto SemiCondensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarcaInstrumento.ForeColor = System.Drawing.Color.White;
            this.txtMarcaInstrumento.Location = new System.Drawing.Point(483, 100);
            this.txtMarcaInstrumento.Name = "txtMarcaInstrumento";
            this.txtMarcaInstrumento.Size = new System.Drawing.Size(100, 15);
            this.txtMarcaInstrumento.TabIndex = 29;
            // 
            // lblEstadoInstrumento
            // 
            this.lblEstadoInstrumento.AutoSize = true;
            this.lblEstadoInstrumento.Font = new System.Drawing.Font("Roboto SemiCondensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoInstrumento.ForeColor = System.Drawing.Color.White;
            this.lblEstadoInstrumento.Location = new System.Drawing.Point(483, 153);
            this.lblEstadoInstrumento.Name = "lblEstadoInstrumento";
            this.lblEstadoInstrumento.Size = new System.Drawing.Size(44, 14);
            this.lblEstadoInstrumento.TabIndex = 28;
            this.lblEstadoInstrumento.Text = "Estado:";
            // 
            // lblMarcaInstrumento
            // 
            this.lblMarcaInstrumento.AutoSize = true;
            this.lblMarcaInstrumento.Font = new System.Drawing.Font("Roboto SemiCondensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcaInstrumento.ForeColor = System.Drawing.Color.White;
            this.lblMarcaInstrumento.Location = new System.Drawing.Point(480, 65);
            this.lblMarcaInstrumento.Name = "lblMarcaInstrumento";
            this.lblMarcaInstrumento.Size = new System.Drawing.Size(42, 14);
            this.lblMarcaInstrumento.TabIndex = 27;
            this.lblMarcaInstrumento.Text = "Marca:";
            // 
            // txtNombreInstrumento
            // 
            this.txtNombreInstrumento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.txtNombreInstrumento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreInstrumento.Font = new System.Drawing.Font("Roboto SemiCondensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreInstrumento.ForeColor = System.Drawing.Color.White;
            this.txtNombreInstrumento.Location = new System.Drawing.Point(93, 100);
            this.txtNombreInstrumento.Name = "txtNombreInstrumento";
            this.txtNombreInstrumento.Size = new System.Drawing.Size(100, 15);
            this.txtNombreInstrumento.TabIndex = 26;
            // 
            // lblCategoriaInstrumento
            // 
            this.lblCategoriaInstrumento.AutoSize = true;
            this.lblCategoriaInstrumento.Font = new System.Drawing.Font("Roboto SemiCondensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriaInstrumento.ForeColor = System.Drawing.Color.White;
            this.lblCategoriaInstrumento.Location = new System.Drawing.Point(90, 154);
            this.lblCategoriaInstrumento.Name = "lblCategoriaInstrumento";
            this.lblCategoriaInstrumento.Size = new System.Drawing.Size(58, 14);
            this.lblCategoriaInstrumento.TabIndex = 25;
            this.lblCategoriaInstrumento.Text = "Categoria:";
            // 
            // lblNombreInstrumento
            // 
            this.lblNombreInstrumento.AutoSize = true;
            this.lblNombreInstrumento.Font = new System.Drawing.Font("Roboto SemiCondensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreInstrumento.ForeColor = System.Drawing.Color.White;
            this.lblNombreInstrumento.Location = new System.Drawing.Point(90, 65);
            this.lblNombreInstrumento.Name = "lblNombreInstrumento";
            this.lblNombreInstrumento.Size = new System.Drawing.Size(50, 14);
            this.lblNombreInstrumento.TabIndex = 24;
            this.lblNombreInstrumento.Text = "Nombre:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel3.Location = new System.Drawing.Point(93, 113);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(136, 2);
            this.panel3.TabIndex = 33;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Location = new System.Drawing.Point(483, 113);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(136, 2);
            this.panel1.TabIndex = 34;
            // 
            // btnActu
            // 
            this.btnActu.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnActu.FlatAppearance.BorderSize = 0;
            this.btnActu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActu.Font = new System.Drawing.Font("Roboto SemiCondensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActu.ForeColor = System.Drawing.Color.White;
            this.btnActu.Location = new System.Drawing.Point(483, 295);
            this.btnActu.Name = "btnActu";
            this.btnActu.Size = new System.Drawing.Size(78, 23);
            this.btnActu.TabIndex = 39;
            this.btnActu.Text = "Actualizar";
            this.btnActu.UseVisualStyleBackColor = false;
            this.btnActu.Click += new System.EventHandler(this.btnActu_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GestionAcademaDeMusica.Properties.Resources.icono_nombre;
            this.pictureBox2.Location = new System.Drawing.Point(203, 86);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 40;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GestionAcademaDeMusica.Properties.Resources.icono_marca;
            this.pictureBox1.Location = new System.Drawing.Point(593, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // ActualizarInstrumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(727, 405);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnActu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.cmbEstadoInstrumento);
            this.Controls.Add(this.cmbCategoriaInstrumento);
            this.Controls.Add(this.txtMarcaInstrumento);
            this.Controls.Add(this.lblEstadoInstrumento);
            this.Controls.Add(this.lblMarcaInstrumento);
            this.Controls.Add(this.txtNombreInstrumento);
            this.Controls.Add(this.lblCategoriaInstrumento);
            this.Controls.Add(this.lblNombreInstrumento);
            this.Name = "ActualizarInstrumento";
            this.Text = "ActualizarInstrumento";
            this.Load += new System.EventHandler(this.ActualizarInstrumento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbEstadoInstrumento;
        private System.Windows.Forms.ComboBox cmbCategoriaInstrumento;
        private System.Windows.Forms.TextBox txtMarcaInstrumento;
        private System.Windows.Forms.Label lblEstadoInstrumento;
        private System.Windows.Forms.Label lblMarcaInstrumento;
        private System.Windows.Forms.TextBox txtNombreInstrumento;
        private System.Windows.Forms.Label lblCategoriaInstrumento;
        private System.Windows.Forms.Label lblNombreInstrumento;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private Model.BotonRedondo btnActu;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}