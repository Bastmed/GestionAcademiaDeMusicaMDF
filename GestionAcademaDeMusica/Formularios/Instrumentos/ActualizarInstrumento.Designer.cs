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
            this.btnActualizar = new System.Windows.Forms.Button();
            this.cmbCategoriaInstrumento = new System.Windows.Forms.ComboBox();
            this.txtMarcaInstrumento = new System.Windows.Forms.TextBox();
            this.lblEstadoInstrumento = new System.Windows.Forms.Label();
            this.lblMarcaInstrumento = new System.Windows.Forms.Label();
            this.txtNombreInstrumento = new System.Windows.Forms.TextBox();
            this.lblCategoriaInstrumento = new System.Windows.Forms.Label();
            this.lblNombreInstrumento = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.cmbEstadoInstrumento.Location = new System.Drawing.Point(486, 185);
            this.cmbEstadoInstrumento.Name = "cmbEstadoInstrumento";
            this.cmbEstadoInstrumento.Size = new System.Drawing.Size(121, 21);
            this.cmbEstadoInstrumento.TabIndex = 32;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(486, 346);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 31;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
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
            this.cmbCategoriaInstrumento.Location = new System.Drawing.Point(93, 185);
            this.cmbCategoriaInstrumento.Name = "cmbCategoriaInstrumento";
            this.cmbCategoriaInstrumento.Size = new System.Drawing.Size(121, 21);
            this.cmbCategoriaInstrumento.TabIndex = 30;
            // 
            // txtMarcaInstrumento
            // 
            this.txtMarcaInstrumento.Location = new System.Drawing.Point(483, 93);
            this.txtMarcaInstrumento.Name = "txtMarcaInstrumento";
            this.txtMarcaInstrumento.Size = new System.Drawing.Size(100, 20);
            this.txtMarcaInstrumento.TabIndex = 29;
            // 
            // lblEstadoInstrumento
            // 
            this.lblEstadoInstrumento.AutoSize = true;
            this.lblEstadoInstrumento.Location = new System.Drawing.Point(483, 153);
            this.lblEstadoInstrumento.Name = "lblEstadoInstrumento";
            this.lblEstadoInstrumento.Size = new System.Drawing.Size(43, 13);
            this.lblEstadoInstrumento.TabIndex = 28;
            this.lblEstadoInstrumento.Text = "Estado:";
            // 
            // lblMarcaInstrumento
            // 
            this.lblMarcaInstrumento.AutoSize = true;
            this.lblMarcaInstrumento.Location = new System.Drawing.Point(480, 65);
            this.lblMarcaInstrumento.Name = "lblMarcaInstrumento";
            this.lblMarcaInstrumento.Size = new System.Drawing.Size(40, 13);
            this.lblMarcaInstrumento.TabIndex = 27;
            this.lblMarcaInstrumento.Text = "Marca:";
            // 
            // txtNombreInstrumento
            // 
            this.txtNombreInstrumento.Location = new System.Drawing.Point(93, 93);
            this.txtNombreInstrumento.Name = "txtNombreInstrumento";
            this.txtNombreInstrumento.Size = new System.Drawing.Size(100, 20);
            this.txtNombreInstrumento.TabIndex = 26;
            // 
            // lblCategoriaInstrumento
            // 
            this.lblCategoriaInstrumento.AutoSize = true;
            this.lblCategoriaInstrumento.Location = new System.Drawing.Point(90, 154);
            this.lblCategoriaInstrumento.Name = "lblCategoriaInstrumento";
            this.lblCategoriaInstrumento.Size = new System.Drawing.Size(55, 13);
            this.lblCategoriaInstrumento.TabIndex = 25;
            this.lblCategoriaInstrumento.Text = "Categoria:";
            // 
            // lblNombreInstrumento
            // 
            this.lblNombreInstrumento.AutoSize = true;
            this.lblNombreInstrumento.Location = new System.Drawing.Point(90, 65);
            this.lblNombreInstrumento.Name = "lblNombreInstrumento";
            this.lblNombreInstrumento.Size = new System.Drawing.Size(47, 13);
            this.lblNombreInstrumento.TabIndex = 24;
            this.lblNombreInstrumento.Text = "Nombre:";
            // 
            // ActualizarInstrumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbEstadoInstrumento);
            this.Controls.Add(this.btnActualizar);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbEstadoInstrumento;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.ComboBox cmbCategoriaInstrumento;
        private System.Windows.Forms.TextBox txtMarcaInstrumento;
        private System.Windows.Forms.Label lblEstadoInstrumento;
        private System.Windows.Forms.Label lblMarcaInstrumento;
        private System.Windows.Forms.TextBox txtNombreInstrumento;
        private System.Windows.Forms.Label lblCategoriaInstrumento;
        private System.Windows.Forms.Label lblNombreInstrumento;
    }
}