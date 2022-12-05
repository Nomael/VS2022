namespace WIndows_Forms_Array
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
            this.btn_eingabe = new System.Windows.Forms.Button();
            this.btn_ausgabe = new System.Windows.Forms.Button();
            this.txt_Eingabe = new System.Windows.Forms.TextBox();
            this.txt_Ausgabe = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_eingabe
            // 
            this.btn_eingabe.Location = new System.Drawing.Point(69, 43);
            this.btn_eingabe.Name = "btn_eingabe";
            this.btn_eingabe.Size = new System.Drawing.Size(200, 85);
            this.btn_eingabe.TabIndex = 0;
            this.btn_eingabe.Text = "Eingabe";
            this.btn_eingabe.UseVisualStyleBackColor = true;
            this.btn_eingabe.Click += new System.EventHandler(this.btn_eingabe_Click);
            // 
            // btn_ausgabe
            // 
            this.btn_ausgabe.Location = new System.Drawing.Point(69, 173);
            this.btn_ausgabe.Name = "btn_ausgabe";
            this.btn_ausgabe.Size = new System.Drawing.Size(200, 85);
            this.btn_ausgabe.TabIndex = 1;
            this.btn_ausgabe.Text = "Ausgabe";
            this.btn_ausgabe.UseVisualStyleBackColor = true;
            this.btn_ausgabe.Click += new System.EventHandler(this.btn_ausgabe_Click);
            // 
            // txt_Eingabe
            // 
            this.txt_Eingabe.Location = new System.Drawing.Point(309, 74);
            this.txt_Eingabe.Name = "txt_Eingabe";
            this.txt_Eingabe.Size = new System.Drawing.Size(465, 22);
            this.txt_Eingabe.TabIndex = 2;
            // 
            // txt_Ausgabe
            // 
            this.txt_Ausgabe.Location = new System.Drawing.Point(309, 173);
            this.txt_Ausgabe.Multiline = true;
            this.txt_Ausgabe.Name = "txt_Ausgabe";
            this.txt_Ausgabe.Size = new System.Drawing.Size(465, 265);
            this.txt_Ausgabe.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_Ausgabe);
            this.Controls.Add(this.txt_Eingabe);
            this.Controls.Add(this.btn_ausgabe);
            this.Controls.Add(this.btn_eingabe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_eingabe;
        private System.Windows.Forms.Button btn_ausgabe;
        private System.Windows.Forms.TextBox txt_Eingabe;
        private System.Windows.Forms.TextBox txt_Ausgabe;
    }
}

