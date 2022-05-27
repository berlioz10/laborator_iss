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
    public partial class ReturCarte : Form
    {
        private Abonat abonat;
        private ExemplarCarteInterfaceRepository exemplarCarteRepo;
        private Boolean ok = false;
        ExemplarCarte exemplarCarte = null;
        public ReturCarte()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void setAndShow(Abonat abonat, ExemplarCarteInterfaceRepository exemplarCarteRepo)
        {
            this.abonat = abonat;
            this.exemplarCarteRepo = exemplarCarteRepo;
            this.loadData();
            this.ShowDialog();
        }

        private void loadData()
        {

        }

        private void returButton_Click(object sender, EventArgs e)
        {
            if (ok == true)
            {
                exemplarCarteRepo.return_carte_rezervat(exemplarCarte);
                this.Close();
            }
            else
            {
                MessageBox.Show("Introduceti un cod valid!");
            }
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
                else if (exemplar.stareRetur == StareRetur.RETURNAT 
                    || exemplar.stareRetur == StareRetur.ASTEPTARE
                    || abonat.rezervate.Any(x => x.id == exemplar.id) == false)
                {
                    carteExistLabel.ForeColor = Color.Red;
                    ok = false;
                    carteExistLabel.Text = "Carte imposibil de returnat";
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
    }
}
