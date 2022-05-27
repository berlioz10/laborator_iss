namespace BibliotecaAppGui
{
    partial class ReturCarte
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
            this.returButton = new System.Windows.Forms.Button();
            this.carteExistLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.codCarteTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // returButton
            // 
            this.returButton.Location = new System.Drawing.Point(84, 154);
            this.returButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.returButton.Name = "returButton";
            this.returButton.Size = new System.Drawing.Size(299, 51);
            this.returButton.TabIndex = 7;
            this.returButton.Text = "Returnează carte";
            this.returButton.UseVisualStyleBackColor = true;
            this.returButton.Click += new System.EventHandler(this.returButton_Click);
            // 
            // carteExistLabel
            // 
            this.carteExistLabel.AutoSize = true;
            this.carteExistLabel.Location = new System.Drawing.Point(15, 64);
            this.carteExistLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.carteExistLabel.Name = "carteExistLabel";
            this.carteExistLabel.Size = new System.Drawing.Size(262, 29);
            this.carteExistLabel.TabIndex = 6;
            this.carteExistLabel.Text = "Această carte nu există!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cod carte:";
            // 
            // codCarteTextBox
            // 
            this.codCarteTextBox.Font = new System.Drawing.Font("Georgia", 14.25F);
            this.codCarteTextBox.Location = new System.Drawing.Point(129, 16);
            this.codCarteTextBox.Margin = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.codCarteTextBox.Name = "codCarteTextBox";
            this.codCarteTextBox.Size = new System.Drawing.Size(364, 34);
            this.codCarteTextBox.TabIndex = 4;
            this.codCarteTextBox.TextChanged += new System.EventHandler(this.codCarteTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Georgia", 10.25F);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(12, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(493, 39);
            this.label2.TabIndex = 8;
            this.label2.Text = "Notă: după ce confirmi returul cărții, trebuie să te duci cu cartea la biblioteca" +
    "r pentru a-i da cartea și pentru a confirma primirea cărții!";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ReturCarte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 219);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.returButton);
            this.Controls.Add(this.carteExistLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.codCarteTextBox);
            this.Font = new System.Drawing.Font("Georgia", 14.25F);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "ReturCarte";
            this.Text = "ReturCarte";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button returButton;
        private System.Windows.Forms.Label carteExistLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox codCarteTextBox;
        private System.Windows.Forms.Label label2;
    }
}