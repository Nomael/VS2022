namespace AB100_Erstes_Windows_Forms_Project
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLESEN = new System.Windows.Forms.Button();
            this.txtEingabe = new System.Windows.Forms.TextBox();
            this.lblAusgabe = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLESEN
            // 
            this.btnLESEN.Location = new System.Drawing.Point(101, 164);
            this.btnLESEN.Name = "btnLESEN";
            this.btnLESEN.Size = new System.Drawing.Size(75, 23);
            this.btnLESEN.TabIndex = 0;
            this.btnLESEN.Text = "LESEN";
            this.btnLESEN.UseVisualStyleBackColor = true;
            this.btnLESEN.Click += new System.EventHandler(this.btnLESEN_Click);
            // 
            // txtEingabe
            // 
            this.txtEingabe.Location = new System.Drawing.Point(89, 84);
            this.txtEingabe.Name = "txtEingabe";
            this.txtEingabe.Size = new System.Drawing.Size(100, 20);
            this.txtEingabe.TabIndex = 1;
            // 
            // lblAusgabe
            // 
            this.lblAusgabe.AutoSize = true;
            this.lblAusgabe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAusgabe.Location = new System.Drawing.Point(213, 87);
            this.lblAusgabe.Name = "lblAusgabe";
            this.lblAusgabe.Size = new System.Drawing.Size(2, 15);
            this.lblAusgabe.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(213, 163);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 277);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblAusgabe);
            this.Controls.Add(this.txtEingabe);
            this.Controls.Add(this.btnLESEN);
            this.Name = "Form1";
            this.Text = "Erstes Programm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLESEN;
        private System.Windows.Forms.TextBox txtEingabe;
        private System.Windows.Forms.Label lblAusgabe;
        private System.Windows.Forms.Button btnClose;
    }
}

