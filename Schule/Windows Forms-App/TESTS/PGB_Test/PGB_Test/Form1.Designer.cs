namespace PGB_Test
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
            this.pgb_01 = new System.Windows.Forms.ProgressBar();
            this.btn_stepper = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pgb_01
            // 
            this.pgb_01.Location = new System.Drawing.Point(243, 73);
            this.pgb_01.Name = "pgb_01";
            this.pgb_01.Size = new System.Drawing.Size(305, 57);
            this.pgb_01.TabIndex = 0;
            this.pgb_01.Click += new System.EventHandler(this.pgb_01_Click);
            // 
            // btn_stepper
            // 
            this.btn_stepper.Location = new System.Drawing.Point(415, 225);
            this.btn_stepper.Name = "btn_stepper";
            this.btn_stepper.Size = new System.Drawing.Size(172, 59);
            this.btn_stepper.TabIndex = 1;
            this.btn_stepper.Text = "Step";
            this.btn_stepper.UseVisualStyleBackColor = true;
            this.btn_stepper.Click += new System.EventHandler(this.btn_stepper_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_stepper);
            this.Controls.Add(this.pgb_01);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar pgb_01;
        private System.Windows.Forms.Button btn_stepper;
    }
}

