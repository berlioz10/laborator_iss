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
    public partial class ImprumutCarte : Form
    {
        private ExemplarCarteInterfaceRepository exemplarCarteRepo;
        private ExemplarCarte exemplarCarte;
        private Abonat abonat;
        bool ok = false;
        public ImprumutCarte()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
     
        }

        private void imprumutButton_Click(object sender, EventArgs e)
        {
            if(ok == true)
            {
                exemplarCarteRepo.add_carte_rezervat(exemplarCarte, abonat);
                this.Close();
            }
            else
            {
                MessageBox.Show("Introduceti un cod valid!");
            }
        }

        private void ImprumutCarti_Load(object sender, EventArgs e)
        {

        }

        public void setAndShow(Abonat abonat, ExemplarCarteInterfaceRepository exemplarCarteRepo)
        {
            this.abonat = abonat;
            this.exemplarCarteRepo = exemplarCarteRepo;
            this.ShowDialog();
        }

        public void setAndShow(Abonat abonat, ExemplarCarteInterfaceRepository exemplarCarteRepo, String cod_unic)
        {
            this.abonat = abonat;
            this.exemplarCarteRepo = exemplarCarteRepo;
            this.codCarteTextBox.Text = cod_unic;
            this.ShowDialog();
        }

        private void codCarteTextBox_TextChanged(object sender, EventArgs e)
        {
            if (codCarteTextBox.Text.Length < 9)
            {
                carteExistLabel.ForeColor = Color.Red;
                carteExistLabel.Text = "Textul este prea scurt";
                ok = false;
            }
            else if (codCarteTextBox.Text.Length > 9)
            {
                carteExistLabel.ForeColor = Color.Red;
                ok = false;
                carteExistLabel.Text = "Textul este prea lung";
            }
            else
            {
                ExemplarCarte exemplar = exemplarCarteRepo.find_by_cod_unic(codCarteTextBox.Text);
                if (exemplar == null)
                {
                    carteExistLabel.ForeColor = Color.Red;
                    ok = false;
                    carteExistLabel.Text = "Cartea nu exista";
                }
                else if(exemplar.stareRetur != StareRetur.RETURNAT)
                {
                    carteExistLabel.ForeColor = Color.Red;
                    ok = false;
                    carteExistLabel.Text = "Carte nereturnata inca";
                }
                else
                {
                    exemplarCarte = exemplar;
                    carteExistLabel.ForeColor = Color.Green;
                    ok = true;
                    carteExistLabel.Text = exemplar.ToString();
                }
            }
        }

        private void carteExistLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
