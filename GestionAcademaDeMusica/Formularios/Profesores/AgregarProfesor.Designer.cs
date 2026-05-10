namespace GestionAcademaDeMusica.Formularios.Profesores
{
    partial class AgregarProfesor
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
            this.lblEstadoAgrProfe = new System.Windows.Forms.Label();
            this.chkEstadoAgrProfe = new System.Windows.Forms.CheckBox();
            this.txtTarifaAgrProfe = new System.Windows.Forms.TextBox();
            this.cmbEspecialidadAgrProfe = new System.Windows.Forms.ComboBox();
            this.txtEmailAgrProfe = new System.Windows.Forms.TextBox();
            this.txtTelefonoAgrProfe = new System.Windows.Forms.TextBox();
            this.txtApellidoAgrProfe = new System.Windows.Forms.TextBox();
            this.txtNombreAgrProfe = new System.Windows.Forms.TextBox();
            this.lblTarifaAgrProfe = new System.Windows.Forms.Label();
            this.lblEspecialidadAgrProfe = new System.Windows.Forms.Label();
            this.lblEmailAgrProfe = new System.Windows.Forms.Label();
            this.lblTelefonoAgrProfe = new System.Windows.Forms.Label();
            this.lblApellidoAgrProfe = new System.Windows.Forms.Label();
            this.lblNombreAgrProfe = new System.Windows.Forms.Label();
            this.lblTarifaIVA = new System.Windows.Forms.Label();
            this.cmbTelefonoAgrProfesor = new System.Windows.Forms.ComboBox();
            this.btnRegistrarPro = new GestionAcademaDeMusica.Model.BotonRedondo();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblEstadoAgrProfe
            // 
            this.lblEstadoAgrProfe.AutoSize = true;
            this.lblEstadoAgrProfe.Location = new System.Drawing.Point(559, 182);
            this.lblEstadoAgrProfe.Name = "lblEstadoAgrProfe";
            this.lblEstadoAgrProfe.Size = new System.Drawing.Size(40, 13);
            this.lblEstadoAgrProfe.TabIndex = 27;
            this.lblEstadoAgrProfe.Text = "Activo:";
            // 
            // chkEstadoAgrProfe
            // 
            this.chkEstadoAgrProfe.AutoSize = true;
            this.chkEstadoAgrProfe.Location = new System.Drawing.Point(562, 207);
            this.chkEstadoAgrProfe.Name = "chkEstadoAgrProfe";
            this.chkEstadoAgrProfe.Size = new System.Drawing.Size(15, 14);
            this.chkEstadoAgrProfe.TabIndex = 26;
            this.chkEstadoAgrProfe.UseVisualStyleBackColor = true;
            // 
            // txtTarifaAgrProfe
            // 
            this.txtTarifaAgrProfe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.txtTarifaAgrProfe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTarifaAgrProfe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTarifaAgrProfe.ForeColor = System.Drawing.Color.White;
            this.txtTarifaAgrProfe.Location = new System.Drawing.Point(562, 87);
            this.txtTarifaAgrProfe.Name = "txtTarifaAgrProfe";
            this.txtTarifaAgrProfe.Size = new System.Drawing.Size(100, 14);
            this.txtTarifaAgrProfe.TabIndex = 25;
            this.txtTarifaAgrProfe.TextChanged += new System.EventHandler(this.txtTarifaAgrProfe_TextChanged);
            // 
            // cmbEspecialidadAgrProfe
            // 
            this.cmbEspecialidadAgrProfe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.cmbEspecialidadAgrProfe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbEspecialidadAgrProfe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEspecialidadAgrProfe.ForeColor = System.Drawing.Color.White;
            this.cmbEspecialidadAgrProfe.FormattingEnabled = true;
            this.cmbEspecialidadAgrProfe.Items.AddRange(new object[] {
            "Guitarra Clásica",
            "Guitarra Eléctrica",
            "Bajo Eléctrico",
            "Piano",
            "Violín",
            "Violoncello",
            "Contrabajo",
            "Flauta Traversa",
            "Clarinete",
            "Saxofón",
            "Trompeta",
            "Trombón",
            "Percusión Clásica",
            "Batería",
            "Arpa",
            "Canto Lírico",
            "Canto Popular",
            "Charango",
            "Quena",
            "Teoría Musical y Solfeo",
            "Composición",
            "Dirección Coral"});
            this.cmbEspecialidadAgrProfe.Location = new System.Drawing.Point(344, 86);
            this.cmbEspecialidadAgrProfe.Name = "cmbEspecialidadAgrProfe";
            this.cmbEspecialidadAgrProfe.Size = new System.Drawing.Size(121, 23);
            this.cmbEspecialidadAgrProfe.TabIndex = 24;
            // 
            // txtEmailAgrProfe
            // 
            this.txtEmailAgrProfe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.txtEmailAgrProfe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmailAgrProfe.ForeColor = System.Drawing.Color.White;
            this.txtEmailAgrProfe.Location = new System.Drawing.Point(136, 362);
            this.txtEmailAgrProfe.Name = "txtEmailAgrProfe";
            this.txtEmailAgrProfe.Size = new System.Drawing.Size(100, 13);
            this.txtEmailAgrProfe.TabIndex = 23;
            // 
            // txtTelefonoAgrProfe
            // 
            this.txtTelefonoAgrProfe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.txtTelefonoAgrProfe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefonoAgrProfe.ForeColor = System.Drawing.Color.White;
            this.txtTelefonoAgrProfe.Location = new System.Drawing.Point(136, 266);
            this.txtTelefonoAgrProfe.Name = "txtTelefonoAgrProfe";
            this.txtTelefonoAgrProfe.Size = new System.Drawing.Size(100, 13);
            this.txtTelefonoAgrProfe.TabIndex = 22;
            // 
            // txtApellidoAgrProfe
            // 
            this.txtApellidoAgrProfe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.txtApellidoAgrProfe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellidoAgrProfe.ForeColor = System.Drawing.Color.White;
            this.txtApellidoAgrProfe.Location = new System.Drawing.Point(136, 182);
            this.txtApellidoAgrProfe.Name = "txtApellidoAgrProfe";
            this.txtApellidoAgrProfe.Size = new System.Drawing.Size(100, 13);
            this.txtApellidoAgrProfe.TabIndex = 21;
            // 
            // txtNombreAgrProfe
            // 
            this.txtNombreAgrProfe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.txtNombreAgrProfe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreAgrProfe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreAgrProfe.ForeColor = System.Drawing.Color.White;
            this.txtNombreAgrProfe.Location = new System.Drawing.Point(136, 88);
            this.txtNombreAgrProfe.Name = "txtNombreAgrProfe";
            this.txtNombreAgrProfe.Size = new System.Drawing.Size(100, 14);
            this.txtNombreAgrProfe.TabIndex = 20;
            // 
            // lblTarifaAgrProfe
            // 
            this.lblTarifaAgrProfe.AutoSize = true;
            this.lblTarifaAgrProfe.Location = new System.Drawing.Point(559, 62);
            this.lblTarifaAgrProfe.Name = "lblTarifaAgrProfe";
            this.lblTarifaAgrProfe.Size = new System.Drawing.Size(37, 13);
            this.lblTarifaAgrProfe.TabIndex = 19;
            this.lblTarifaAgrProfe.Text = "Tarifa:";
            // 
            // lblEspecialidadAgrProfe
            // 
            this.lblEspecialidadAgrProfe.AutoSize = true;
            this.lblEspecialidadAgrProfe.Location = new System.Drawing.Point(341, 62);
            this.lblEspecialidadAgrProfe.Name = "lblEspecialidadAgrProfe";
            this.lblEspecialidadAgrProfe.Size = new System.Drawing.Size(70, 13);
            this.lblEspecialidadAgrProfe.TabIndex = 18;
            this.lblEspecialidadAgrProfe.Text = "Especialidad:";
            // 
            // lblEmailAgrProfe
            // 
            this.lblEmailAgrProfe.AutoSize = true;
            this.lblEmailAgrProfe.Location = new System.Drawing.Point(133, 330);
            this.lblEmailAgrProfe.Name = "lblEmailAgrProfe";
            this.lblEmailAgrProfe.Size = new System.Drawing.Size(35, 13);
            this.lblEmailAgrProfe.TabIndex = 17;
            this.lblEmailAgrProfe.Text = "Email:";
            // 
            // lblTelefonoAgrProfe
            // 
            this.lblTelefonoAgrProfe.AutoSize = true;
            this.lblTelefonoAgrProfe.Location = new System.Drawing.Point(133, 237);
            this.lblTelefonoAgrProfe.Name = "lblTelefonoAgrProfe";
            this.lblTelefonoAgrProfe.Size = new System.Drawing.Size(52, 13);
            this.lblTelefonoAgrProfe.TabIndex = 16;
            this.lblTelefonoAgrProfe.Text = "Telefono:";
            // 
            // lblApellidoAgrProfe
            // 
            this.lblApellidoAgrProfe.AutoSize = true;
            this.lblApellidoAgrProfe.Location = new System.Drawing.Point(133, 151);
            this.lblApellidoAgrProfe.Name = "lblApellidoAgrProfe";
            this.lblApellidoAgrProfe.Size = new System.Drawing.Size(47, 13);
            this.lblApellidoAgrProfe.TabIndex = 15;
            this.lblApellidoAgrProfe.Text = "Apellido:";
            // 
            // lblNombreAgrProfe
            // 
            this.lblNombreAgrProfe.AutoSize = true;
            this.lblNombreAgrProfe.Location = new System.Drawing.Point(133, 62);
            this.lblNombreAgrProfe.Name = "lblNombreAgrProfe";
            this.lblNombreAgrProfe.Size = new System.Drawing.Size(47, 13);
            this.lblNombreAgrProfe.TabIndex = 14;
            this.lblNombreAgrProfe.Text = "Nombre:";
            // 
            // lblTarifaIVA
            // 
            this.lblTarifaIVA.AutoSize = true;
            this.lblTarifaIVA.Location = new System.Drawing.Point(561, 136);
            this.lblTarifaIVA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTarifaIVA.Name = "lblTarifaIVA";
            this.lblTarifaIVA.Size = new System.Drawing.Size(93, 13);
            this.lblTarifaIVA.TabIndex = 30;
            this.lblTarifaIVA.Text = "Con IVA (19%): $0";
            // 
            // cmbTelefonoAgrProfesor
            // 
            this.cmbTelefonoAgrProfesor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.cmbTelefonoAgrProfesor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTelefonoAgrProfesor.ForeColor = System.Drawing.Color.White;
            this.cmbTelefonoAgrProfesor.FormattingEnabled = true;
            this.cmbTelefonoAgrProfesor.Location = new System.Drawing.Point(12, 265);
            this.cmbTelefonoAgrProfesor.Name = "cmbTelefonoAgrProfesor";
            this.cmbTelefonoAgrProfesor.Size = new System.Drawing.Size(101, 21);
            this.cmbTelefonoAgrProfesor.TabIndex = 31;
            // 
            // btnRegistrarPro
            // 
            this.btnRegistrarPro.BackColor = System.Drawing.Color.DarkGray;
            this.btnRegistrarPro.FlatAppearance.BorderSize = 0;
            this.btnRegistrarPro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarPro.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarPro.Location = new System.Drawing.Point(562, 285);
            this.btnRegistrarPro.Name = "btnRegistrarPro";
            this.btnRegistrarPro.Size = new System.Drawing.Size(78, 23);
            this.btnRegistrarPro.TabIndex = 41;
            this.btnRegistrarPro.Text = "Registrar";
            this.btnRegistrarPro.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.Location = new System.Drawing.Point(562, 107);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(144, 2);
            this.panel3.TabIndex = 43;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Location = new System.Drawing.Point(136, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(144, 2);
            this.panel1.TabIndex = 44;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Location = new System.Drawing.Point(136, 200);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(144, 2);
            this.panel2.TabIndex = 45;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkGray;
            this.panel4.Location = new System.Drawing.Point(136, 284);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(144, 2);
            this.panel4.TabIndex = 46;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkGray;
            this.panel5.Location = new System.Drawing.Point(136, 380);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(144, 2);
            this.panel5.TabIndex = 47;
            // 
            // AgregarProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnRegistrarPro);
            this.Controls.Add(this.cmbTelefonoAgrProfesor);
            this.Controls.Add(this.lblTarifaIVA);
            this.Controls.Add(this.lblEstadoAgrProfe);
            this.Controls.Add(this.chkEstadoAgrProfe);
            this.Controls.Add(this.txtTarifaAgrProfe);
            this.Controls.Add(this.cmbEspecialidadAgrProfe);
            this.Controls.Add(this.txtEmailAgrProfe);
            this.Controls.Add(this.txtTelefonoAgrProfe);
            this.Controls.Add(this.txtApellidoAgrProfe);
            this.Controls.Add(this.txtNombreAgrProfe);
            this.Controls.Add(this.lblTarifaAgrProfe);
            this.Controls.Add(this.lblEspecialidadAgrProfe);
            this.Controls.Add(this.lblEmailAgrProfe);
            this.Controls.Add(this.lblTelefonoAgrProfe);
            this.Controls.Add(this.lblApellidoAgrProfe);
            this.Controls.Add(this.lblNombreAgrProfe);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "AgregarProfesor";
            this.Text = "AgregarProfesor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEstadoAgrProfe;
        private System.Windows.Forms.CheckBox chkEstadoAgrProfe;
        private System.Windows.Forms.TextBox txtTarifaAgrProfe;
        private System.Windows.Forms.ComboBox cmbEspecialidadAgrProfe;
        private System.Windows.Forms.TextBox txtEmailAgrProfe;
        private System.Windows.Forms.TextBox txtTelefonoAgrProfe;
        private System.Windows.Forms.TextBox txtApellidoAgrProfe;
        private System.Windows.Forms.TextBox txtNombreAgrProfe;
        private System.Windows.Forms.Label lblTarifaAgrProfe;
        private System.Windows.Forms.Label lblEspecialidadAgrProfe;
        private System.Windows.Forms.Label lblEmailAgrProfe;
        private System.Windows.Forms.Label lblTelefonoAgrProfe;
        private System.Windows.Forms.Label lblApellidoAgrProfe;
        private System.Windows.Forms.Label lblNombreAgrProfe;
        private System.Windows.Forms.Label lblTarifaIVA;
        private System.Windows.Forms.ComboBox cmbTelefonoAgrProfesor;
        private Model.BotonRedondo btnRegistrarPro;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
    }
}