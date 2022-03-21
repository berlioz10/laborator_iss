namespace BibliotecaAppGui
{
    partial class ImprumutCarte
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
            this.codCarteTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.carteExistLabel = new System.Windows.Forms.Label();
            this.imprumutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // codCarteTextBox
            // 
            this.codCarteTextBox.Font = new System.Drawing.Font("Georgia", 14.25F);
            this.codCarteTextBox.Location = new System.Drawing.Point(119, 14);
            this.codCarteTextBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.codCarteTextBox.Name = "codCarteTextBox";
            this.codCarteTextBox.Size = new System.Drawing.Size(250, 29);
            this.codCarteTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cod carte:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // carteExistLabel
            // 
            this.carteExistLabel.AutoSize = true;
            this.carteExistLabel.Location = new System.Drawing.Point(12, 48);
            this.carteExistLabel.Name = "carteExistLabel";
            this.carteExistLabel.Size = new System.Drawing.Size(212, 23);
            this.carteExistLabel.TabIndex = 2;
            this.carteExistLabel.Text = "Această carte nu există!";
            // 
            // imprumutButton
            // 
            this.imprumutButton.Location = new System.Drawing.Point(73, 84);
            this.imprumutButton.Name = "imprumutButton";
            this.imprumutButton.Size = new System.Drawing.Size(204, 37);
            this.imprumutButton.TabIndex = 3;
            this.imprumutButton.Text = "Împrumută carte";
            this.imprumutButton.UseVisualStyleBackColor = true;
            this.imprumutButton.Click += new System.EventHandler(this.imprumutButton_Click);
            // 
            // ImprumutCarti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 130);
            this.Controls.Add(this.imprumutButton);
            this.Controls.Add(this.carteExistLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.codCarteTextBox);
            this.Font = new System.Drawing.Font("Georgia", 14.25F);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "ImprumutCarti";
            this.Text = "Imprumuta carte";
            this.Load += new System.EventHandler(this.ImprumutCarti_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox codCarteTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label carteExistLabel;
        private System.Windows.Forms.Button imprumutButton;
    }
}