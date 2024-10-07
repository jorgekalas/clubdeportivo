namespace Proyecto
{
    partial class FrmPrincipal
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
            btnRegistrarCliente = new Button();
            btnCobrarCuota = new Button();
            btnListadoMorosos = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnRegistrarCliente
            // 
            btnRegistrarCliente.BackColor = SystemColors.ActiveCaption;
            btnRegistrarCliente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegistrarCliente.Location = new Point(200, 150);
            btnRegistrarCliente.Name = "btnRegistrarCliente";
            btnRegistrarCliente.Size = new Size(196, 70);
            btnRegistrarCliente.TabIndex = 0;
            btnRegistrarCliente.Text = "Registrar Cliente";
            btnRegistrarCliente.UseVisualStyleBackColor = false;
            btnRegistrarCliente.Click += btnRegistrarCliente_Click;
            // 
            // btnCobrarCuota
            // 
            btnCobrarCuota.BackColor = SystemColors.ActiveCaption;
            btnCobrarCuota.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCobrarCuota.Location = new Point(449, 150);
            btnCobrarCuota.Name = "btnCobrarCuota";
            btnCobrarCuota.Size = new Size(196, 70);
            btnCobrarCuota.TabIndex = 1;
            btnCobrarCuota.Text = "Cobrar Cuota";
            btnCobrarCuota.UseVisualStyleBackColor = false;
            btnCobrarCuota.Click += btnCobrarCuota_Click;
            // 
            // btnListadoMorosos
            // 
            btnListadoMorosos.BackColor = SystemColors.ActiveCaption;
            btnListadoMorosos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnListadoMorosos.Location = new Point(324, 267);
            btnListadoMorosos.Name = "btnListadoMorosos";
            btnListadoMorosos.Size = new Size(196, 70);
            btnListadoMorosos.TabIndex = 2;
            btnListadoMorosos.Text = "Obtener Listado de Clientes Morosos";
            btnListadoMorosos.UseVisualStyleBackColor = false;
            btnListadoMorosos.Click += btnListadoMorosos_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(310, 61);
            label2.Name = "label2";
            label2.Size = new Size(245, 28);
            label2.TabIndex = 3;
            label2.Text = "SELECCIONE UNA OPCION";
            label2.Click += label2_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(btnListadoMorosos);
            Controls.Add(btnCobrarCuota);
            Controls.Add(btnRegistrarCliente);
            Name = "FrmPrincipal";
            Text = "Club Deportivo | Opciones";
            Load += FrmPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegistrarCliente;
        private Button btnCobrarCuota;
        private Button btnListadoMorosos;
        private Label label2;
    }
}