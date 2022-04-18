using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaAppGui.Models
{
    public class ExemplarCarte : Entity
    {
        public string cod_unic { get; set; }
        public DateTime data_rezervare { get; set; }
        public Calitate calitate { get; set; }
        public StareRetur stareRetur { get; set; }
        public Carte carte { get; set; }
        public ExemplarCarte(int id, string cod_unic, DateTime data_rezervare, Calitate calitate, StareRetur stareRetur, Carte carte) : base(id)
        {
            this.cod_unic = cod_unic;
            this.data_rezervare = data_rezervare;
            this.calitate = calitate;
            this.stareRetur = stareRetur;
            this.carte = carte;
        }
    }
}
