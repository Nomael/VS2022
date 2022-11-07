namespace Steuerelement_MessageBox
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
            this.bnt_msgbox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bnt_msgbox
            // 
            this.bnt_msgbox.Location = new System.Drawing.Point(260, 149);
            this.bnt_msgbox.Name = "bnt_msgbox";
            this.bnt_msgbox.Size = new System.Drawing.Size(283, 109);
            this.bnt_msgbox.TabIndex = 0;
            this.bnt_msgbox.Text = "Amoung";
            this.bnt_msgbox.UseVisualStyleBackColor = true;
            this.bnt_msgbox.Click += new System.EventHandler(this.bnt_msgbox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bnt_msgbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bnt_msgbox;
    }
}

