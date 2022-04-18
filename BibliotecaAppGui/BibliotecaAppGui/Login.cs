using BibliotecaAppGui.Models;
using BibliotecaAppGui.Repo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaAppGui
{
    public partial class Login : Form
    {
        AbonatInterfaceRepository abonatRepo = null;
        MainBiblioteca mainBiblioteca = null;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                Abonat abonat = abonatRepo.validateDatas(codTextBox.Text);
                if (abonat == null)
                    MessageBox.Show("Acest cod unic este inexistent!");
                else
                {
                    mainBiblioteca.setAbonat(abonat);
                    Close();
                }
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message); 
            }
        }

        internal void setAndShow(AbonatInterfaceRepository abonatRepo, MainBiblioteca mainBiblioteca)
        {
            this.abonatRepo = abonatRepo;
            this.mainBiblioteca = mainBiblioteca;
            ShowDialog();
        }
    }
}
