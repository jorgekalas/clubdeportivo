namespace Proyecto
{
    partial class FrmInscripcion
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
            txtNombre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            cboTipoDocumento = new ComboBox();
            label3 = new Label();
            txtApellido = new TextBox();
            label4 = new Label();
            txtDocumento = new TextBox();
            label5 = new Label();
            btnRegistrar = new Button();
            btnLimpiar = new Button();
            btnVolver = new Button();
            chkSocio = new CheckBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(446, 86);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(249, 29);
            txtNombre.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(338, 89);
            label1.Name = "label1";
            label1.Size = new Size(89, 21);
            label1.TabIndex = 1;
            label1.Text = "Nombre (*)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(296, 18);
            label2.Name = "label2";
            label2.Size = new Size(235, 28);
            label2.TabIndex = 2;
            label2.Text = "INSCRIPCION DE CLIENTE";
            // 
            // cboTipoDocumento
            // 
            cboTipoDocumento.FormattingEnabled = true;
            cboTipoDocumento.Items.AddRange(new object[] { "DNI", "Pasaporte", "Cédula", "Otro" });
            cboTipoDocumento.Location = new Point(498, 180);
            cboTipoDocumento.Name = "cboTipoDocumento";
            cboTipoDocumento.Size = new Size(121, 23);
            cboTipoDocumento.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(338, 136);
            label3.Name = "label3";
            label3.Size = new Size(88, 21);
            label3.TabIndex = 5;
            label3.Text = "Apellido (*)";
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtApellido.Location = new Point(446, 133);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(249, 29);
            txtApellido.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(338, 182);
            label4.Name = "label4";
            label4.Size = new Size(149, 21);
            label4.TabIndex = 6;
            label4.Text = "Documento: Tipo (*)";
            // 
            // txtDocumento
            // 
            txtDocumento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDocumento.Location = new Point(521, 222);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(188, 29);
            txtDocumento.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(338, 222);
            label5.Name = "label5";
            label5.Size = new Size(177, 21);
            label5.TabIndex = 8;
            label5.Text = "Documento: Numero (*)";
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = SystemColors.ActiveCaption;
            btnRegistrar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegistrar.Location = new Point(117, 367);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(126, 42);
            btnRegistrar.TabIndex = 9;
            btnRegistrar.Text = "REGISTRAR";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = SystemColors.ActiveCaption;
            btnLimpiar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpiar.Location = new Point(339, 367);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(126, 42);
            btnLimpiar.TabIndex = 10;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = SystemColors.ActiveCaption;
            btnVolver.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnVolver.Location = new Point(572, 367);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(126, 42);
            btnVolver.TabIndex = 11;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // chkSocio
            // 
            chkSocio.AutoSize = true;
            chkSocio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chkSocio.Location = new Point(338, 267);
            chkSocio.Name = "chkSocio";
            chkSocio.Size = new Size(105, 25);
            chkSocio.TabIndex = 12;
            chkSocio.Text = "Es socio (*)";
            chkSocio.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.img2;
            pictureBox1.ImageLocation = "";
            pictureBox1.Location = new Point(62, 75);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(240, 265);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // FrmInscripcion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(chkSocio);
            Controls.Add(btnVolver);
            Controls.Add(btnLimpiar);
            Controls.Add(btnRegistrar);
            Controls.Add(label5);
            Controls.Add(txtDocumento);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtApellido);
            Controls.Add(cboTipoDocumento);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNombre);
            Name = "FrmInscripcion";
            Text = "Inscripcion de Cliente";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private Label label1;
        private Label label2;
        private ComboBox cboTipoDocumento;
        private Label label3;
        private TextBox txtApellido;
        private Label label4;
        private TextBox txtDocumento;
        private Label label5;
        private Button btnRegistrar;
        private Button btnLimpiar;
        private Button btnVolver;
        private CheckBox chkSocio;
        private PictureBox pictureBox1;
    }
}