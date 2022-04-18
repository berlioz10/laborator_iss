using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaAppGui.Models
{
    public abstract class Entity
    {
        public int id { get; }

        public Entity(int id)
        {
            this.id = id;
        }
    }
}
