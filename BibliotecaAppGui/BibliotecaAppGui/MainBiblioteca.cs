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
    public partial class MainBiblioteca : Form
    {
        private Abonat abonat = null;
        private AbonatInterfaceRepository abonatRepo = null;
        private BibliotecarInterfaceRepository bibliotecarRepo = null;
        private ExemplarCarteInterfaceRepository exemplarCarteRepo = null;
        
        public MainBiblioteca(
            AbonatInterfaceRepository abonatRepo, 
            BibliotecarInterfaceRepository bibliotecarRepo,
            ExemplarCarteInterfaceRepository exemplarCarteRepo)
        {
            this.abonatRepo = abonatRepo;
            this.bibliotecarRepo = bibliotecarRepo;
            this.exemplarCarteRepo = exemplarCarteRepo;
            InitializeComponent();
            loadData();
        }

        public void loadData()
        {
            IList<ExemplarCarte> list = exemplarCarteRepo.find_all_possible();
            vizualizareCartiList.Items.Clear();
            foreach(ExemplarCarte el in list)
            {
                vizualizareCartiList.Items.Add(el);
            }
        }

        public void setAbonat(Abonat abonat)
        {
            this.abonat = abonat;
            imprumutButton.Enabled = true;
            returButton.Enabled = true;
            vizReturButton.Enabled = true;
            logoutButton.Enabled = true;
            signupButton.Enabled = false;
            loginButton.Enabled = false;
            label1.Visible = true;
            label1.Text = "Bun venit, " + this.abonat.nume + "!";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            imprumutButton.Enabled = false;
            returButton.Enabled = false;
            vizReturButton.Enabled = false;
            logoutButton.Enabled = false;
            label1.Visible = false;
            loginButton.Enabled = true;
            signupButton.Enabled = true;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Login form = new Login();
            form.setAndShow(abonatRepo, this);
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            abonat = null;
            imprumutButton.Enabled = false;
            returButton.Enabled = false;
            vizReturButton.Enabled = false;
            logoutButton.Enabled = false;
            label1.Visible = false;
            loginButton.Enabled = true;
            signupButton.Enabled = true;
        }

        private void vizReturButton_Click(object sender, EventArgs e)
        {
            VizReturCarti form = new VizReturCarti();
            form.setAndShow(exemplarCarteRepo, abonat);
        }

        private void returButton_Click(object sender, EventArgs e)
        {
            ReturCarte form = new ReturCarte();
            form.setAndShow(abonat, exemplarCarteRepo);
        }

        private void imprumutButton_Click(object sender, EventArgs e)
        {
            ImprumutCarte form = new ImprumutCarte();
            form.setAndShow(abonat, exemplarCarteRepo);
            loadData();
        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            Inregistrare form = new Inregistrare();
            form.setAndShow(abonatRepo, bibliotecarRepo, this);
        }
    }
}
