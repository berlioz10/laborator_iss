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
    public partial class MainBiblioteca : Form
    {
        public MainBiblioteca()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Login form = new Login();
            form.ShowDialog();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {

        }

        private void vizReturButton_Click(object sender, EventArgs e)
        {
            VizReturCarti form = new VizReturCarti();
            form.ShowDialog();
        }

        private void returButton_Click(object sender, EventArgs e)
        {
            ReturCarte form = new ReturCarte();
            form.ShowDialog();
        }

        private void imprumutButton_Click(object sender, EventArgs e)
        {
            ImprumutCarte form = new ImprumutCarte();
            form.ShowDialog();
        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            Inregistrare form = new Inregistrare();
            form.ShowDialog();
        }
    }
}
