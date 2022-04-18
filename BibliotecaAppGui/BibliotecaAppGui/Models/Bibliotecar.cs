using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaAppGui.Models
{
    public class Bibliotecar : Entity
    {
        public string cod_unic { get; set; }
        public string nume { get; set; }
        public Bibliotecar(int id, string cod_unic, string nume) : base(id)
        {
            this.cod_unic = cod_unic;
            this.nume = nume;
        }
    }
}
