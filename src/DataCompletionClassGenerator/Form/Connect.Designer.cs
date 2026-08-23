namespace DataCompletionClassGenerator.Forms
{
    partial class Connect
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
            this.DSNSelectorCmb = new System.Windows.Forms.ComboBox();
            this.DSNSelectorLbl = new System.Windows.Forms.Label();
            this.UIDInputterLbl = new System.Windows.Forms.Label();
            this.UIDInputterTxt = new System.Windows.Forms.TextBox();
            this.PSWInputterTxt = new System.Windows.Forms.TextBox();
            this.PSWInputterLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DSNSelectorCmb
            // 
            this.DSNSelectorCmb.FormattingEnabled = true;
            this.DSNSelectorCmb.Location = new System.Drawing.Point(99, 9);
            this.DSNSelectorCmb.Name = "DSNSelectorCmb";
            this.DSNSelectorCmb.Size = new System.Drawing.Size(381, 20);
            this.DSNSelectorCmb.TabIndex = 0;
            // 
            // DSNSelectorLbl
            // 
            this.DSNSelectorLbl.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.DSNSelectorLbl.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DSNSelectorLbl.Location = new System.Drawing.Point(12, 9);
            this.DSNSelectorLbl.Name = "DSNSelectorLbl";
            this.DSNSelectorLbl.Size = new System.Drawing.Size(52, 20);
            this.DSNSelectorLbl.TabIndex = 1;
            this.DSNSelectorLbl.Text = "DSN";
            this.DSNSelectorLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DSNSelectorLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // UIDInputterLbl
            // 
            this.UIDInputterLbl.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.UIDInputterLbl.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UIDInputterLbl.Location = new System.Drawing.Point(12, 29);
            this.UIDInputterLbl.Name = "UIDInputterLbl";
            this.UIDInputterLbl.Size = new System.Drawing.Size(52, 20);
            this.UIDInputterLbl.TabIndex = 2;
            this.UIDInputterLbl.Text = "UID";
            this.UIDInputterLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UIDInputterTxt
            // 
            this.UIDInputterTxt.Location = new System.Drawing.Point(99, 29);
            this.UIDInputterTxt.Multiline = true;
            this.UIDInputterTxt.Name = "UIDInputterTxt";
            this.UIDInputterTxt.Size = new System.Drawing.Size(381, 20);
            this.UIDInputterTxt.TabIndex = 3;
            // 
            // PSWInputterTxt
            // 
            this.PSWInputterTxt.Location = new System.Drawing.Point(99, 49);
            this.PSWInputterTxt.Multiline = true;
            this.PSWInputterTxt.Name = "PSWInputterTxt";
            this.PSWInputterTxt.Size = new System.Drawing.Size(381, 20);
            this.PSWInputterTxt.TabIndex = 5;
            this.PSWInputterTxt.UseSystemPasswordChar = true;
            // 
            // PSWInputterLbl
            // 
            this.PSWInputterLbl.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PSWInputterLbl.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PSWInputterLbl.Location = new System.Drawing.Point(12, 49);
            this.PSWInputterLbl.Name = "PSWInputterLbl";
            this.PSWInputterLbl.Size = new System.Drawing.Size(52, 20);
            this.PSWInputterLbl.TabIndex = 4;
            this.PSWInputterLbl.Text = "PSW";
            this.PSWInputterLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Connect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 450);
            this.Controls.Add(this.PSWInputterTxt);
            this.Controls.Add(this.PSWInputterLbl);
            this.Controls.Add(this.UIDInputterTxt);
            this.Controls.Add(this.UIDInputterLbl);
            this.Controls.Add(this.DSNSelectorLbl);
            this.Controls.Add(this.DSNSelectorCmb);
            this.Name = "Connect";
            this.Text = "Connector";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox DSNSelectorCmb;
        private System.Windows.Forms.Label DSNSelectorLbl;
        private System.Windows.Forms.Label UIDInputterLbl;
        private System.Windows.Forms.TextBox UIDInputterTxt;
        private System.Windows.Forms.TextBox PSWInputterTxt;
        private System.Windows.Forms.Label PSWInputterLbl;
    }
}