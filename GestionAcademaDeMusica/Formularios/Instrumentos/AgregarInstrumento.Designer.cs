namespace GestionAcademaDeMusica
{
    partial class AgregarInstrumento
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
            this.txtMarcaInstrumento = new System.Windows.Forms.TextBox();
            this.lblEstadoInstrumento = new System.Windows.Forms.Label();
            this.lblMarcaInstrumento = new System.Windows.Forms.Label();
            this.txtNombreInstrumento = new System.Windows.Forms.TextBox();
            this.lblCategoriaInstrumento = new System.Windows.Forms.Label();
            this.lblNombreInstrumento = new System.Windows.Forms.Label();
            this.cmbCategoriaInstrumento = new System.Windows.Forms.ComboBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.cmbEstadoInstrumento = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtMarcaInstrumento
            // 
            this.txtMarcaInstrumento.Location = new System.Drawing.Point(483, 92);
            this.txtMarcaInstrumento.Name = "txtMarcaInstrumento";
            this.txtMarcaInstrumento.Size = new System.Drawing.Size(100, 20);
            this.txtMarcaInstrumento.TabIndex = 20;
            // 
            // lblEstadoInstrumento
            // 
            this.lblEstadoInstrumento.AutoSize = true;
            this.lblEstadoInstrumento.Location = new System.Drawing.Point(483, 152);
            this.lblEstadoInstrumento.Name = "lblEstadoInstrumento";
            this.lblEstadoInstrumento.Size = new System.Drawing.Size(43, 13);
            this.lblEstadoInstrumento.TabIndex = 19;
            this.lblEstadoInstrumento.Text = "Estado:";
            // 
            // lblMarcaInstrumento
            // 
            this.lblMarcaInstrumento.AutoSize = true;
            this.lblMarcaInstrumento.Location = new System.Drawing.Point(480, 64);
            this.lblMarcaInstrumento.Name = "lblMarcaInstrumento";
            this.lblMarcaInstrumento.Size = new System.Drawing.Size(40, 13);
            this.lblMarcaInstrumento.TabIndex = 18;
            this.lblMarcaInstrumento.Text = "Marca:";
            // 
            // txtNombreInstrumento
            // 
            this.txtNombreInstrumento.Location = new System.Drawing.Point(93, 92);
            this.txtNombreInstrumento.Name = "txtNombreInstrumento";
            this.txtNombreInstrumento.Size = new System.Drawing.Size(100, 20);
            this.txtNombreInstrumento.TabIndex = 16;
            // 
            // lblCategoriaInstrumento
            // 
            this.lblCategoriaInstrumento.AutoSize = true;
            this.lblCategoriaInstrumento.Location = new System.Drawing.Point(90, 153);
            this.lblCategoriaInstrumento.Name = "lblCategoriaInstrumento";
            this.lblCategoriaInstrumento.Size = new System.Drawing.Size(55, 13);
            this.lblCategoriaInstrumento.TabIndex = 15;
            this.lblCategoriaInstrumento.Text = "Categoria:";
            // 
            // lblNombreInstrumento
            // 
            this.lblNombreInstrumento.AutoSize = true;
            this.lblNombreInstrumento.Location = new System.Drawing.Point(90, 64);
            this.lblNombreInstrumento.Name = "lblNombreInstrumento";
            this.lblNombreInstrumento.Size = new System.Drawing.Size(47, 13);
            this.lblNombreInstrumento.TabIndex = 14;
            this.lblNombreInstrumento.Text = "Nombre:";
            // 
            // cmbCategoriaInstrumento
            // 
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
            this.cmbCategoriaInstrumento.Location = new System.Drawing.Point(93, 184);
            this.cmbCategoriaInstrumento.Name = "cmbCategoriaInstrumento";
            this.cmbCategoriaInstrumento.Size = new System.Drawing.Size(121, 21);
            this.cmbCategoriaInstrumento.TabIndex = 21;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(486, 345);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 22;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // cmbEstadoInstrumento
            // 
            this.cmbEstadoInstrumento.FormattingEnabled = true;
            this.cmbEstadoInstrumento.Items.AddRange(new object[] {
            "Disponible",
            "En uso",
            "En mantenimiento",
            "Deteriorado",
            "De baja"});
            this.cmbEstadoInstrumento.Location = new System.Drawing.Point(486, 184);
            this.cmbEstadoInstrumento.Name = "cmbEstadoInstrumento";
            this.cmbEstadoInstrumento.Size = new System.Drawing.Size(121, 21);
            this.cmbEstadoInstrumento.TabIndex = 23;
            // 
            // AgregarInstrumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbEstadoInstrumento);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.cmbCategoriaInstrumento);
            this.Controls.Add(this.txtMarcaInstrumento);
            this.Controls.Add(this.lblEstadoInstrumento);
            this.Controls.Add(this.lblMarcaInstrumento);
            this.Controls.Add(this.txtNombreInstrumento);
            this.Controls.Add(this.lblCategoriaInstrumento);
            this.Controls.Add(this.lblNombreInstrumento);
            this.Name = "AgregarInstrumento";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMarcaInstrumento;
        private System.Windows.Forms.Label lblEstadoInstrumento;
        private System.Windows.Forms.Label lblMarcaInstrumento;
        private System.Windows.Forms.TextBox txtNombreInstrumento;
        private System.Windows.Forms.Label lblCategoriaInstrumento;
        private System.Windows.Forms.Label lblNombreInstrumento;
        private System.Windows.Forms.ComboBox cmbCategoriaInstrumento;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.ComboBox cmbEstadoInstrumento;
    }
}