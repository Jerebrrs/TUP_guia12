namespace Examen_2
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
            Cargas = new GroupBox();
            label2 = new Label();
            tbcapacidad = new TextBox();
            btnCerrarCam = new Button();
            btnDescargar = new Button();
            btnCargarCamion = new Button();
            btnCrearCamion = new Button();
            lbAutos = new ListBox();
            label1 = new Label();
            dtpFecha = new DateTimePicker();
            groupBox1 = new GroupBox();
            btnDescRecibidos = new Button();
            btnRecibirCamion = new Button();
            lbrecibidos = new ListBox();
            label3 = new Label();
            Cargas.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // Cargas
            // 
            Cargas.Controls.Add(label2);
            Cargas.Controls.Add(tbcapacidad);
            Cargas.Controls.Add(btnCerrarCam);
            Cargas.Controls.Add(btnDescargar);
            Cargas.Controls.Add(btnCargarCamion);
            Cargas.Controls.Add(btnCrearCamion);
            Cargas.Controls.Add(lbAutos);
            Cargas.Controls.Add(label1);
            Cargas.Controls.Add(dtpFecha);
            Cargas.Location = new Point(12, 12);
            Cargas.Name = "Cargas";
            Cargas.Size = new Size(448, 328);
            Cargas.TabIndex = 0;
            Cargas.TabStop = false;
            Cargas.Text = "Cargas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(325, 66);
            label2.Name = "label2";
            label2.Size = new Size(111, 15);
            label2.TabIndex = 8;
            label2.Text = "Capacidad Camion:";
            // 
            // tbcapacidad
            // 
            tbcapacidad.Location = new Point(325, 96);
            tbcapacidad.Name = "tbcapacidad";
            tbcapacidad.Size = new Size(66, 23);
            tbcapacidad.TabIndex = 7;
            // 
            // btnCerrarCam
            // 
            btnCerrarCam.Location = new Point(227, 243);
            btnCerrarCam.Name = "btnCerrarCam";
            btnCerrarCam.Size = new Size(75, 51);
            btnCerrarCam.TabIndex = 6;
            btnCerrarCam.Text = "Cerrar camion";
            btnCerrarCam.UseVisualStyleBackColor = true;
            btnCerrarCam.Click += btnCerrarCam_Click;
            // 
            // btnDescargar
            // 
            btnDescargar.Location = new Point(227, 193);
            btnDescargar.Name = "btnDescargar";
            btnDescargar.Size = new Size(75, 34);
            btnDescargar.TabIndex = 5;
            btnDescargar.Text = "Descargar";
            btnDescargar.UseVisualStyleBackColor = true;
            btnDescargar.Click += btnDescargar_Click;
            // 
            // btnCargarCamion
            // 
            btnCargarCamion.Location = new Point(227, 151);
            btnCargarCamion.Name = "btnCargarCamion";
            btnCargarCamion.Size = new Size(75, 36);
            btnCargarCamion.TabIndex = 4;
            btnCargarCamion.Text = "Cargar";
            btnCargarCamion.UseVisualStyleBackColor = true;
            btnCargarCamion.Click += button2_Click;
            // 
            // btnCrearCamion
            // 
            btnCrearCamion.Location = new Point(227, 96);
            btnCrearCamion.Name = "btnCrearCamion";
            btnCrearCamion.Size = new Size(75, 39);
            btnCrearCamion.TabIndex = 3;
            btnCrearCamion.Text = "Crear Camion";
            btnCrearCamion.UseVisualStyleBackColor = true;
            btnCrearCamion.Click += btnCrearCamion_Click;
            // 
            // lbAutos
            // 
            lbAutos.FormattingEnabled = true;
            lbAutos.ItemHeight = 15;
            lbAutos.Location = new Point(17, 96);
            lbAutos.Name = "lbAutos";
            lbAutos.Size = new Size(194, 214);
            lbAutos.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 66);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 1;
            label1.Text = "Lista de Autos:";
            // 
            // dtpFecha
            // 
            dtpFecha.CustomFormat = "dd/MM/yy";
            dtpFecha.Location = new Point(96, 22);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(238, 23);
            dtpFecha.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnDescRecibidos);
            groupBox1.Controls.Add(btnRecibirCamion);
            groupBox1.Controls.Add(lbrecibidos);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(466, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(322, 328);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Descargas:";
            // 
            // btnDescRecibidos
            // 
            btnDescRecibidos.Location = new Point(224, 170);
            btnDescRecibidos.Name = "btnDescRecibidos";
            btnDescRecibidos.Size = new Size(75, 57);
            btnDescRecibidos.TabIndex = 5;
            btnDescRecibidos.Text = "Descargar";
            btnDescRecibidos.UseVisualStyleBackColor = true;
            btnDescRecibidos.Click += btnDescRecibidos_Click;
            // 
            // btnRecibirCamion
            // 
            btnRecibirCamion.Location = new Point(224, 96);
            btnRecibirCamion.Name = "btnRecibirCamion";
            btnRecibirCamion.Size = new Size(75, 57);
            btnRecibirCamion.TabIndex = 4;
            btnRecibirCamion.Text = "Recibir Camion";
            btnRecibirCamion.UseVisualStyleBackColor = true;
            btnRecibirCamion.Click += btnRecibirCamion_Click;
            // 
            // lbrecibidos
            // 
            lbrecibidos.FormattingEnabled = true;
            lbrecibidos.ItemHeight = 15;
            lbrecibidos.Location = new Point(6, 66);
            lbrecibidos.Name = "lbrecibidos";
            lbrecibidos.Size = new Size(200, 244);
            lbrecibidos.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 48);
            label3.Name = "label3";
            label3.Size = new Size(101, 15);
            label3.TabIndex = 2;
            label3.Text = "Lista de recibidos:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 345);
            Controls.Add(groupBox1);
            Controls.Add(Cargas);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Cargas.ResumeLayout(false);
            Cargas.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox Cargas;
        private TextBox tbcapacidad;
        private Button btnCerrarCam;
        private Button btnDescargar;
        private Button btnCargarCamion;
        private Button btnCrearCamion;
        private ListBox lbAutos;
        private Label label1;
        private DateTimePicker dtpFecha;
        private Label label2;
        private GroupBox groupBox1;
        private Button btnRecibirCamion;
        private ListBox lbrecibidos;
        private Label label3;
        private Button btnDescRecibidos;
    }
}
