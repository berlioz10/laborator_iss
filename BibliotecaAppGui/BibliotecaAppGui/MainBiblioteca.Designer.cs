namespace BibliotecaAppGui
{
    partial class MainBiblioteca
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
            this.vizualizareCartiList = new System.Windows.Forms.ListBox();
            this.logoutButton = new System.Windows.Forms.Button();
            this.imprumutButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.returButton = new System.Windows.Forms.Button();
            this.vizReturButton = new System.Windows.Forms.Button();
            this.signupButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // vizualizareCartiList
            // 
            this.vizualizareCartiList.Font = new System.Drawing.Font("Georgia", 14.25F);
            this.vizualizareCartiList.FormattingEnabled = true;
            this.vizualizareCartiList.ItemHeight = 29;
            this.vizualizareCartiList.Location = new System.Drawing.Point(16, 15);
            this.vizualizareCartiList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.vizualizareCartiList.Name = "vizualizareCartiList";
            this.vizualizareCartiList.Size = new System.Drawing.Size(878, 584);
            this.vizualizareCartiList.TabIndex = 0;
            // 
            // logoutButton
            // 
            this.logoutButton.Font = new System.Drawing.Font("Georgia", 14.25F);
            this.logoutButton.Location = new System.Drawing.Point(1103, 13);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(188, 103);
            this.logoutButton.TabIndex = 1;
            this.logoutButton.Text = "Delogare";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // imprumutButton
            // 
            this.imprumutButton.Font = new System.Drawing.Font("Georgia", 14.25F);
            this.imprumutButton.Location = new System.Drawing.Point(907, 228);
            this.imprumutButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.imprumutButton.Name = "imprumutButton";
            this.imprumutButton.Size = new System.Drawing.Size(188, 95);
            this.imprumutButton.TabIndex = 2;
            this.imprumutButton.Text = "Împrumută carte";
            this.imprumutButton.UseVisualStyleBackColor = true;
            this.imprumutButton.Click += new System.EventHandler(this.imprumutButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.Location = new System.Drawing.Point(907, 13);
            this.loginButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(188, 103);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "Autentificare";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // returButton
            // 
            this.returButton.Font = new System.Drawing.Font("Georgia", 14.25F);
            this.returButton.Location = new System.Drawing.Point(1103, 124);
            this.returButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.returButton.Name = "returButton";
            this.returButton.Size = new System.Drawing.Size(188, 95);
            this.returButton.TabIndex = 4;
            this.returButton.Text = "Returnează carte";
            this.returButton.UseVisualStyleBackColor = true;
            this.returButton.Click += new System.EventHandler(this.returButton_Click);
            // 
            // vizReturButton
            // 
            this.vizReturButton.Font = new System.Drawing.Font("Georgia", 14.25F);
            this.vizReturButton.Location = new System.Drawing.Point(907, 125);
            this.vizReturButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.vizReturButton.Name = "vizReturButton";
            this.vizReturButton.Size = new System.Drawing.Size(188, 95);
            this.vizReturButton.TabIndex = 5;
            this.vizReturButton.Text = "Vizualizare returnare cărți";
            this.vizReturButton.UseVisualStyleBackColor = true;
            this.vizReturButton.Click += new System.EventHandler(this.vizReturButton_Click);
            // 
            // signupButton
            // 
            this.signupButton.Font = new System.Drawing.Font("Georgia", 14.25F);
            this.signupButton.Location = new System.Drawing.Point(1103, 228);
            this.signupButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.signupButton.Name = "signupButton";
            this.signupButton.Size = new System.Drawing.Size(188, 95);
            this.signupButton.TabIndex = 6;
            this.signupButton.Text = "Înregistrare";
            this.signupButton.UseVisualStyleBackColor = true;
            this.signupButton.Click += new System.EventHandler(this.signupButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 14.25F);
            this.label1.Location = new System.Drawing.Point(902, 386);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // MainBiblioteca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 620);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.signupButton);
            this.Controls.Add(this.vizReturButton);
            this.Controls.Add(this.returButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.imprumutButton);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.vizualizareCartiList);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainBiblioteca";
            this.Text = "Biblioteca";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox vizualizareCartiList;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button imprumutButton;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button returButton;
        private System.Windows.Forms.Button vizReturButton;
        private System.Windows.Forms.Button signupButton;
        private System.Windows.Forms.Label label1;
    }
}

