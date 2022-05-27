using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaAppGui.Models
{
    public class Abonat : Entity
    {
        public virtual string cod_unic { get; set; }
        public virtual string nume { get; set; }
        public virtual string adresa { get; set; }
        public virtual string cnp { get; set; }
        public virtual IList<ExemplarCarte> rezervate { get; set; }
        public Abonat() : base(0)
        {

        }
        public Abonat(int id, string cod_unic, string nume, string adresa, string cnp, IList<ExemplarCarte> rezervate) : base(id)
        {
            this.cod_unic = cod_unic;
            this.nume = nume;
            this.adresa = adresa;
            this.cnp = cnp;
            this.rezervate = rezervate;
        }
    }
}
