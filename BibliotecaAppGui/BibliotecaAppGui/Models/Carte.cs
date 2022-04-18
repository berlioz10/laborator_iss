using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaAppGui.Models
{
    public class Carte : Entity
    {
        private string nume { get; set; }
        private string autor { get; set; }

        public Carte(int id, string nume, string autor) : base(id)
        {
            this.nume = nume;
            this.autor = autor;

         }
    }
}
