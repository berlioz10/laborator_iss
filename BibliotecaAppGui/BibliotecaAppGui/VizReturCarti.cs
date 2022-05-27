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
    public partial class VizReturCarti : Form
    {
        private ExemplarCarteInterfaceRepository exemplarCarteRepo;
        private Abonat abonat;
        public VizReturCarti()
        {
            InitializeComponent();
        }

        public void setAndShow(ExemplarCarteInterfaceRepository exemplarCarteRepo, Abonat abonat)
        {
            this.exemplarCarteRepo = exemplarCarteRepo;
            this.abonat = abonat;
            this.loadData();
            this.ShowDialog();
        }

        private void loadData()
        {
            IList<ExemplarCarte> list = exemplarCarteRepo.find_all_abonat(abonat);
            listBox1.Items.Clear();
            foreach (ExemplarCarte el in list)
            {
                listBox1.Items.Add(el);
            }
        }

        private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            ExemplarCarte exemplar = (ExemplarCarte)listBox1.Items[e.Index];

            if (exemplar.stareRetur == StareRetur.ASTEPTARE)
            {
                e.Graphics.DrawString(((ListBox)sender).Items[e.Index].ToString(),
                    e.Font, Brushes.DeepPink, e.Bounds, StringFormat.GenericDefault);
            }
            else
            {
                e.Graphics.DrawString(((ListBox)sender).Items[e.Index].ToString(),
                e.Font, Brushes.Black, e.Bounds, StringFormat.GenericDefault);
            }
        }

        private void VizReturCarti_Load(object sender, EventArgs e)
        {

        }
    }
}
