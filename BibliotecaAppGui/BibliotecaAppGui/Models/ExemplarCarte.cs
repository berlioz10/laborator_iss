using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaAppGui.Models
{
    public class ExemplarCarte : Entity
    {
        public virtual string cod_unic { get; set; }
        public virtual DateTime data_rezervare { get; set; }
        public virtual Calitate calitate { get; set; }
        public virtual StareRetur stareRetur { get; set; }
        public virtual Carte carte { get; set; }
        public virtual Abonat abonat { get; set; }

        public ExemplarCarte() : base(0)
        {

        }
        public ExemplarCarte(int id, string cod_unic, DateTime data_rezervare, Calitate calitate, StareRetur stareRetur, Carte carte) : base(id)
        {
            this.cod_unic = cod_unic;
            this.data_rezervare = data_rezervare;
            this.calitate = calitate;
            this.stareRetur = stareRetur;
            this.carte = carte;
        }

        public override string ToString()
        {
            return cod_unic + ": " + carte.nume + " de " + carte.autor + " - " + calitate;
        }
    }
}
