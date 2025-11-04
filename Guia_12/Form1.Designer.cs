namespace Guia_12
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            tbDni = new TextBox();
            btnTicket = new Button();
            rbDenuncia = new RadioButton();
            contextMenuStrip1 = new ContextMenuStrip(components);
            menuStrip1 = new MenuStrip();
            cbTipo = new ComboBox();
            label2 = new Label();
            tbPatente = new TextBox();
            rbCliente = new RadioButton();
            label3 = new Label();
            lbTurnos = new ListBox();
            btnExportarticket = new Button();
            btnImportarVehiculos = new Button();
            btnAtenderCliente = new Button();
            btnAtenderDenun = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 25);
            label1.Name = "label1";
            label1.Size = new Size(27, 15);
            label1.TabIndex = 0;
            label1.Text = "DNI";
            // 
            // tbDni
            // 
            tbDni.Location = new Point(89, 22);
            tbDni.Name = "tbDni";
            tbDni.Size = new Size(160, 23);
            tbDni.TabIndex = 1;
            // 
            // btnTicket
            // 
            btnTicket.Location = new Point(268, 96);
            btnTicket.Name = "btnTicket";
            btnTicket.Size = new Size(94, 75);
            btnTicket.TabIndex = 2;
            btnTicket.Text = "Crear Ticket";
            btnTicket.UseVisualStyleBackColor = true;
            btnTicket.Click += btnTicket_Click;
            // 
            // rbDenuncia
            // 
            rbDenuncia.AutoSize = true;
            rbDenuncia.Location = new Point(38, 100);
            rbDenuncia.Name = "rbDenuncia";
            rbDenuncia.Size = new Size(75, 19);
            rbDenuncia.TabIndex = 3;
            rbDenuncia.TabStop = true;
            rbDenuncia.Text = "Denuncia";
            rbDenuncia.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // menuStrip1
            // 
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(372, 24);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // cbTipo
            // 
            cbTipo.FormattingEnabled = true;
            cbTipo.Location = new Point(144, 148);
            cbTipo.Name = "cbTipo";
            cbTipo.Size = new Size(105, 23);
            cbTipo.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 65);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 7;
            label2.Text = "Datos del Cliente";
            // 
            // tbPatente
            // 
            tbPatente.Location = new Point(144, 100);
            tbPatente.Name = "tbPatente";
            tbPatente.Size = new Size(105, 23);
            tbPatente.TabIndex = 8;
            // 
            // rbCliente
            // 
            rbCliente.AutoSize = true;
            rbCliente.Location = new Point(38, 152);
            rbCliente.Name = "rbCliente";
            rbCliente.Size = new Size(100, 19);
            rbCliente.TabIndex = 9;
            rbCliente.TabStop = true;
            rbCliente.Text = "Nuevo Cliente";
            rbCliente.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 206);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 10;
            label3.Text = "Turnos";
            // 
            // lbTurnos
            // 
            lbTurnos.FormattingEnabled = true;
            lbTurnos.ItemHeight = 15;
            lbTurnos.Location = new Point(38, 237);
            lbTurnos.Name = "lbTurnos";
            lbTurnos.Size = new Size(211, 94);
            lbTurnos.TabIndex = 11;
            // 
            // btnExportarticket
            // 
            btnExportarticket.Location = new Point(277, 237);
            btnExportarticket.Name = "btnExportarticket";
            btnExportarticket.Size = new Size(78, 41);
            btnExportarticket.TabIndex = 12;
            btnExportarticket.Text = "Exportar Tickets";
            btnExportarticket.UseVisualStyleBackColor = true;
            // 
            // btnImportarVehiculos
            // 
            btnImportarVehiculos.Location = new Point(277, 284);
            btnImportarVehiculos.Name = "btnImportarVehiculos";
            btnImportarVehiculos.Size = new Size(78, 38);
            btnImportarVehiculos.TabIndex = 13;
            btnImportarVehiculos.Text = "Importar Vehiculos";
            btnImportarVehiculos.UseVisualStyleBackColor = true;
            // 
            // btnAtenderCliente
            // 
            btnAtenderCliente.Location = new Point(155, 337);
            btnAtenderCliente.Name = "btnAtenderCliente";
            btnAtenderCliente.Size = new Size(94, 46);
            btnAtenderCliente.TabIndex = 14;
            btnAtenderCliente.Text = "Atender Nuevo Cliente";
            btnAtenderCliente.UseVisualStyleBackColor = true;
            btnAtenderCliente.Click += btnAtenderCliente_Click;
            // 
            // btnAtenderDenun
            // 
            btnAtenderDenun.Location = new Point(38, 337);
            btnAtenderDenun.Name = "btnAtenderDenun";
            btnAtenderDenun.Size = new Size(94, 46);
            btnAtenderDenun.TabIndex = 15;
            btnAtenderDenun.Text = "Atender Denuncias";
            btnAtenderDenun.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(372, 400);
            Controls.Add(btnAtenderDenun);
            Controls.Add(btnAtenderCliente);
            Controls.Add(btnImportarVehiculos);
            Controls.Add(btnExportarticket);
            Controls.Add(lbTurnos);
            Controls.Add(label3);
            Controls.Add(rbCliente);
            Controls.Add(tbPatente);
            Controls.Add(label2);
            Controls.Add(cbTipo);
            Controls.Add(menuStrip1);
            Controls.Add(rbDenuncia);
            Controls.Add(btnTicket);
            Controls.Add(tbDni);
            Controls.Add(label1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbDni;
        private Button btnTicket;
        private RadioButton rbDenuncia;
        private ContextMenuStrip contextMenuStrip1;
        private MenuStrip menuStrip1;
        private ComboBox cbTipo;
        private Label label2;
        private TextBox tbPatente;
        private RadioButton rbCliente;
        private Label label3;
        private ListBox lbTurnos;
        private Button btnExportarticket;
        private Button btnImportarVehiculos;
        private Button btnAtenderCliente;
        private Button btnAtenderDenun;
    }
}
