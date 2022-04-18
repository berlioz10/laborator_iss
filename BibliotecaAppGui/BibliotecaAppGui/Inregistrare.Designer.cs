namespace BibliotecaAppGui
{
    partial class Inregistrare
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
            this.numeTextBox = new System.Windows.Forms.TextBox();
            this.cnpTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.adresaTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.codBTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.inregistrareButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numeTextBox
            // 
            this.numeTextBox.Location = new System.Drawing.Point(89, 9);
            this.numeTextBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.numeTextBox.Name = "numeTextBox";
            this.numeTextBox.Size = new System.Drawing.Size(407, 34);
            this.numeTextBox.TabIndex = 0;
            // 
            // cnpTextBox
            // 
            this.cnpTextBox.Location = new System.Drawing.Point(89, 46);
            this.cnpTextBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cnpTextBox.Name = "cnpTextBox";
            this.cnpTextBox.Size = new System.Drawing.Size(407, 34);
            this.cnpTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nume:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "CNP:";
            // 
            // adresaTextBox
            // 
            this.adresaTextBox.Location = new System.Drawing.Point(89, 88);
            this.adresaTextBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.adresaTextBox.Multiline = true;
            this.adresaTextBox.Name = "adresaTextBox";
            this.adresaTextBox.Size = new System.Drawing.Size(407, 89);
            this.adresaTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Adresă:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cod Bibliotecar:";
            // 
            // codBTextBox
            // 
            this.codBTextBox.Location = new System.Drawing.Point(160, 184);
            this.codBTextBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.codBTextBox.Name = "codBTextBox";
            this.codBTextBox.Size = new System.Drawing.Size(336, 34);
            this.codBTextBox.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Georgia", 10.25F);
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(6, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(493, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Notă: un bibliotecar trebuie să confirme detaliile tale înainte de a te înregistr" +
    "a!";
            // 
            // button1
            // 
            this.inregistrareButton.Location = new System.Drawing.Point(160, 246);
            this.inregistrareButton.Name = "button1";
            this.inregistrareButton.Size = new System.Drawing.Size(176, 49);
            this.inregistrareButton.TabIndex = 10;
            this.inregistrareButton.Text = "Înregistrare";
            this.inregistrareButton.UseVisualStyleBackColor = true;
            this.inregistrareButton.Click += new System.EventHandler(this.inregistrareButton_Click);
            // 
            // Inregistrare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 307);
            this.Controls.Add(this.inregistrareButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.codBTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.adresaTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cnpTextBox);
            this.Controls.Add(this.numeTextBox);
            this.Font = new System.Drawing.Font("Georgia", 14.25F);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Inregistrare";
            this.Text = "Inregistrare";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numeTextBox;
        private System.Windows.Forms.TextBox cnpTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox adresaTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox codBTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button inregistrareButton;
    }
}