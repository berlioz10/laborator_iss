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
    public partial class Inregistrare : Form
    {
        private AbonatInterfaceRepository abonatRepo = null;
        private BibliotecarInterfaceRepository bibliotecarRepo = null;
        private MainBiblioteca main = null;

        public Inregistrare()
        {
            InitializeComponent();
        }

        public void setAndShow(AbonatInterfaceRepository abonatRepo, BibliotecarInterfaceRepository bibliotecarRepo, MainBiblioteca mainBiblioteca)
        {
            this.abonatRepo = abonatRepo;
            this.bibliotecarRepo = bibliotecarRepo;
            this.main = mainBiblioteca;
            ShowDialog();
        }

        private void inregistrareButton_Click(object sender, EventArgs e)
        {
            try
            {
                Bibliotecar bibliotecar = bibliotecarRepo.FindByCodUnic(codBTextBox.Text);

                string cod_unic = generateRandomCodUnic(abonatRepo.find_all());

                Abonat abonat = new Abonat(-1, cod_unic, numeTextBox.Text, adresaTextBox.Text, cnpTextBox.Text, null);
                abonatRepo.addWithBibliotecar(abonat, bibliotecar.id);
                Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string generateRandomCodUnic(IList<Abonat> abonats)
        {
            Random random = new Random();
            string cifre = "0123456789";
            string cod_unic = "";
            do
                cod_unic = string.Join("", Enumerable.Repeat(cifre, 9).Select(s => s[random.Next(s.Length)]).ToArray());
            while (abonats.Any(s => s.cod_unic == cod_unic));

            return cod_unic;
        }
    }
}
