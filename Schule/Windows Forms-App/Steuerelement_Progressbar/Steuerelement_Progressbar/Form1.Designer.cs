namespace Steuerelement_Progressbar
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
            this.btn_stprog = new System.Windows.Forms.Button();
            this.pgb_display = new System.Windows.Forms.ProgressBar();
            this.pgb_display2 = new System.Windows.Forms.ProgressBar();
            this.pgb_display3 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_stprog3 = new System.Windows.Forms.Button();
            this.btn_stprog2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_stprog
            // 
            this.btn_stprog.Location = new System.Drawing.Point(192, 273);
            this.btn_stprog.Name = "btn_stprog";
            this.btn_stprog.Size = new System.Drawing.Size(147, 76);
            this.btn_stprog.TabIndex = 1;
            this.btn_stprog.Text = "Start Programm 1";
            this.btn_stprog.UseVisualStyleBackColor = true;
            this.btn_stprog.Click += new System.EventHandler(this.btn_stprog_Click);
            // 
            // pgb_display
            // 
            this.pgb_display.Location = new System.Drawing.Point(192, 48);
            this.pgb_display.Name = "pgb_display";
            this.pgb_display.Size = new System.Drawing.Size(585, 39);
            this.pgb_display.TabIndex = 2;
            // 
            // pgb_display2
            // 
            this.pgb_display2.Location = new System.Drawing.Point(192, 110);
            this.pgb_display2.Name = "pgb_display2";
            this.pgb_display2.Size = new System.Drawing.Size(585, 39);
            this.pgb_display2.TabIndex = 3;
            // 
            // pgb_display3
            // 
            this.pgb_display3.Location = new System.Drawing.Point(192, 176);
            this.pgb_display3.Name = "pgb_display3";
            this.pgb_display3.Size = new System.Drawing.Size(585, 39);
            this.pgb_display3.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "None";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "None";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "None";
            // 
            // btn_stprog3
            // 
            this.btn_stprog3.Location = new System.Drawing.Point(630, 273);
            this.btn_stprog3.Name = "btn_stprog3";
            this.btn_stprog3.Size = new System.Drawing.Size(147, 76);
            this.btn_stprog3.TabIndex = 8;
            this.btn_stprog3.Text = "Start Programm 3";
            this.btn_stprog3.UseVisualStyleBackColor = true;
            this.btn_stprog3.Click += new System.EventHandler(this.btn_stprog3_Click);
            // 
            // btn_stprog2
            // 
            this.btn_stprog2.Location = new System.Drawing.Point(410, 273);
            this.btn_stprog2.Name = "btn_stprog2";
            this.btn_stprog2.Size = new System.Drawing.Size(147, 76);
            this.btn_stprog2.TabIndex = 9;
            this.btn_stprog2.Text = "Start Programm 2";
            this.btn_stprog2.UseVisualStyleBackColor = true;
            this.btn_stprog2.Click += new System.EventHandler(this.btn_stprog2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_stprog2);
            this.Controls.Add(this.btn_stprog3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pgb_display3);
            this.Controls.Add(this.pgb_display2);
            this.Controls.Add(this.pgb_display);
            this.Controls.Add(this.btn_stprog);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_stprog;
        private System.Windows.Forms.ProgressBar pgb_display;
        private System.Windows.Forms.ProgressBar pgb_display2;
        private System.Windows.Forms.ProgressBar pgb_display3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_stprog3;
        private System.Windows.Forms.Button btn_stprog2;
    }
}

