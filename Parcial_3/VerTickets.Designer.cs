namespace Parcial_3
{
    partial class VerTickets
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
            lbTicket = new ListBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // lbTicket
            // 
            lbTicket.FormattingEnabled = true;
            lbTicket.ItemHeight = 15;
            lbTicket.Location = new Point(12, 12);
            lbTicket.Name = "lbTicket";
            lbTicket.Size = new Size(347, 199);
            lbTicket.TabIndex = 0;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.Cancel;
            button1.Location = new Point(125, 217);
            button1.Name = "button1";
            button1.Size = new Size(107, 35);
            button1.TabIndex = 1;
            button1.Text = "Cerrar";
            button1.UseVisualStyleBackColor = true;
            // 
            // VerTickets
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(370, 278);
            Controls.Add(button1);
            Controls.Add(lbTicket);
            Name = "VerTickets";
            Text = "VerTickets";
            ResumeLayout(false);
        }

        #endregion

        public ListBox lbTicket;
        private Button button1;
    }
}