using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaAppGui.Models
{
    public class ExemplarCarteDTO
    {
        public virtual Int32 Id { get; set; }
        public virtual Abonat Abonat { get; set; }
        public virtual ExemplarCarte ExemplarCarte { get; set; }
    }
}
