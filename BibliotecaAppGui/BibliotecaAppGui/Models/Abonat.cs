using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaAppGui.Models
{
    public class Abonat : Entity
    {
        public string cod_unic { get; set; }
        public string nume { get; set; }
        public string adresa { get; set; }
        public string cnp { get; set; }
        public IList<ExemplarCarte> rezervate { get; set; }
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
