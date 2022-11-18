namespace Knopf_Bewegung
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
            this.btn_button = new System.Windows.Forms.Button();
            this.nud_NummericY = new System.Windows.Forms.NumericUpDown();
            this.nud_NummericX = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nud_NummericY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_NummericX)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_button
            // 
            this.btn_button.Location = new System.Drawing.Point(335, 146);
            this.btn_button.Name = "btn_button";
            this.btn_button.Size = new System.Drawing.Size(136, 68);
            this.btn_button.TabIndex = 0;
            this.btn_button.Text = "button1";
            this.btn_button.UseVisualStyleBackColor = true;
            this.btn_button.Click += new System.EventHandler(this.btn_button_Click);
            // 
            // nud_NummericY
            // 
            this.nud_NummericY.Location = new System.Drawing.Point(560, 319);
            this.nud_NummericY.Name = "nud_NummericY";
            this.nud_NummericY.Size = new System.Drawing.Size(120, 22);
            this.nud_NummericY.TabIndex = 1;
            // 
            // nud_NummericX
            // 
            this.nud_NummericX.Location = new System.Drawing.Point(132, 319);
            this.nud_NummericX.Name = "nud_NummericX";
            this.nud_NummericX.Size = new System.Drawing.Size(120, 22);
            this.nud_NummericX.TabIndex = 2;
            this.nud_NummericX.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nud_NummericX);
            this.Controls.Add(this.nud_NummericY);
            this.Controls.Add(this.btn_button);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nud_NummericY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_NummericX)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_button;
        private System.Windows.Forms.NumericUpDown nud_NummericY;
        private System.Windows.Forms.NumericUpDown nud_NummericX;
    }
}

