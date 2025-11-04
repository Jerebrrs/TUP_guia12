namespace Parcial_3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            cbDestinos = new ComboBox();
            label2 = new Label();
            tbPrecio = new TextBox();
            label3 = new Label();
            cbTransporte = new ComboBox();
            btnGenerar = new Button();
            btnResumen = new Button();
            groupBox1 = new GroupBox();
            tbTarjeta = new TextBox();
            tbNombre = new TextBox();
            tbTelefono = new TextBox();
            tbCuit = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            btnEjemplo = new Button();
            btnSalir = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 24);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 0;
            label1.Text = "Destino:";
            // 
            // cbDestinos
            // 
            cbDestinos.FormattingEnabled = true;
            cbDestinos.Location = new Point(118, 21);
            cbDestinos.Name = "cbDestinos";
            cbDestinos.Size = new Size(217, 23);
            cbDestinos.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 68);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 2;
            label2.Text = "Precio:";
            // 
            // tbPrecio
            // 
            tbPrecio.Location = new Point(235, 68);
            tbPrecio.Name = "tbPrecio";
            tbPrecio.Size = new Size(100, 23);
            tbPrecio.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 130);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 4;
            label3.Text = "Transporte:";
            // 
            // cbTransporte
            // 
            cbTransporte.FormattingEnabled = true;
            cbTransporte.Location = new Point(189, 122);
            cbTransporte.Name = "cbTransporte";
            cbTransporte.Size = new Size(146, 23);
            cbTransporte.TabIndex = 5;
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(393, 21);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(82, 32);
            btnGenerar.TabIndex = 6;
            btnGenerar.Text = "Generar:";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // btnResumen
            // 
            btnResumen.Location = new Point(393, 113);
            btnResumen.Name = "btnResumen";
            btnResumen.Size = new Size(82, 32);
            btnResumen.TabIndex = 7;
            btnResumen.Text = "Resumen:";
            btnResumen.UseVisualStyleBackColor = true;
            btnResumen.Click += btnResumen_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbTarjeta);
            groupBox1.Controls.Add(tbNombre);
            groupBox1.Controls.Add(tbTelefono);
            groupBox1.Controls.Add(tbCuit);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(32, 173);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(422, 214);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos Pasajero";
            // 
            // tbTarjeta
            // 
            tbTarjeta.Location = new Point(113, 135);
            tbTarjeta.Name = "tbTarjeta";
            tbTarjeta.Size = new Size(190, 23);
            tbTarjeta.TabIndex = 12;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(113, 63);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(190, 23);
            tbNombre.TabIndex = 11;
            // 
            // tbTelefono
            // 
            tbTelefono.Location = new Point(113, 95);
            tbTelefono.Name = "tbTelefono";
            tbTelefono.Size = new Size(190, 23);
            tbTelefono.TabIndex = 10;
            // 
            // tbCuit
            // 
            tbCuit.Location = new Point(113, 27);
            tbCuit.Name = "tbCuit";
            tbCuit.Size = new Size(190, 23);
            tbCuit.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 103);
            label7.Name = "label7";
            label7.Size = new Size(56, 15);
            label7.TabIndex = 8;
            label7.Text = "Telefono:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 71);
            label6.Name = "label6";
            label6.Size = new Size(54, 15);
            label6.TabIndex = 7;
            label6.Text = "Nombre:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 143);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 6;
            label5.Text = "N Tarjeta:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 30);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 5;
            label4.Text = "CUIT/CUIL:";
            // 
            // btnEjemplo
            // 
            btnEjemplo.Location = new Point(50, 393);
            btnEjemplo.Name = "btnEjemplo";
            btnEjemplo.Size = new Size(82, 32);
            btnEjemplo.TabIndex = 9;
            btnEjemplo.Text = "Ejemplo";
            btnEjemplo.UseVisualStyleBackColor = true;
            btnEjemplo.Click += btnEjemplo_Click;
            // 
            // btnSalir
            // 
            btnSalir.DialogResult = DialogResult.Cancel;
            btnSalir.Location = new Point(318, 393);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(82, 32);
            btnSalir.TabIndex = 10;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(490, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnEjemplo);
            Controls.Add(groupBox1);
            Controls.Add(btnResumen);
            Controls.Add(btnGenerar);
            Controls.Add(cbTransporte);
            Controls.Add(label3);
            Controls.Add(tbPrecio);
            Controls.Add(label2);
            Controls.Add(cbDestinos);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cbDestinos;
        private Label label2;
        private TextBox tbPrecio;
        private Label label3;
        private ComboBox cbTransporte;
        private Button btnGenerar;
        private Button btnResumen;
        private GroupBox groupBox1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox tbTarjeta;
        private TextBox tbNombre;
        private TextBox tbTelefono;
        private TextBox tbCuit;
        private Button btnEjemplo;
        private Button btnSalir;
    }
}
