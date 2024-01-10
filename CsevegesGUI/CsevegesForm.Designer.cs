namespace CsevegesGUI
{
    partial class CsevegesForm
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
            lblUI01 = new Label();
            lblUI02 = new Label();
            cbxKezdemenyezok = new ComboBox();
            cbxFogadok = new ComboBox();
            rtbCsevegesek = new RichTextBox();
            lblUI03 = new Label();
            SuspendLayout();
            // 
            // lblUI01
            // 
            lblUI01.AutoSize = true;
            lblUI01.Location = new Point(12, 32);
            lblUI01.Name = "lblUI01";
            lblUI01.Size = new Size(116, 21);
            lblUI01.TabIndex = 10;
            lblUI01.Text = "kezdeményező:";
            // 
            // lblUI02
            // 
            lblUI02.AutoSize = true;
            lblUI02.Location = new Point(12, 79);
            lblUI02.Name = "lblUI02";
            lblUI02.Size = new Size(127, 21);
            lblUI02.TabIndex = 10;
            lblUI02.Text = "fogadó (partner):";
            // 
            // cbxKezdemenyezok
            // 
            cbxKezdemenyezok.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxKezdemenyezok.FormattingEnabled = true;
            cbxKezdemenyezok.Location = new Point(165, 29);
            cbxKezdemenyezok.Name = "cbxKezdemenyezok";
            cbxKezdemenyezok.Size = new Size(216, 29);
            cbxKezdemenyezok.TabIndex = 0;
            // 
            // cbxFogadok
            // 
            cbxFogadok.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxFogadok.FormattingEnabled = true;
            cbxFogadok.Location = new Point(165, 76);
            cbxFogadok.Name = "cbxFogadok";
            cbxFogadok.Size = new Size(216, 29);
            cbxFogadok.TabIndex = 1;
            // 
            // rtbCsevegesek
            // 
            rtbCsevegesek.Location = new Point(12, 181);
            rtbCsevegesek.Name = "rtbCsevegesek";
            rtbCsevegesek.Size = new Size(369, 332);
            rtbCsevegesek.TabIndex = 2;
            rtbCsevegesek.TabStop = false;
            rtbCsevegesek.Text = "";
            // 
            // lblUI03
            // 
            lblUI03.AutoSize = true;
            lblUI03.Location = new Point(12, 143);
            lblUI03.Name = "lblUI03";
            lblUI03.Size = new Size(91, 21);
            lblUI03.TabIndex = 10;
            lblUI03.Text = "csevegések:";
            // 
            // CsevegesForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(393, 525);
            Controls.Add(rtbCsevegesek);
            Controls.Add(cbxFogadok);
            Controls.Add(cbxKezdemenyezok);
            Controls.Add(lblUI03);
            Controls.Add(lblUI02);
            Controls.Add(lblUI01);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 4, 4, 4);
            Name = "CsevegesForm";
            Text = "Csevegés GUI";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUI01;
        private Label lblUI02;
        private ComboBox cbxKezdemenyezok;
        private ComboBox cbxFogadok;
        private RichTextBox rtbCsevegesek;
        private Label lblUI03;
    }
}
