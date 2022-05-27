using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaAppGui.Models
{
    public abstract class Entity
    {
        public virtual int id { get; set;  }

        public Entity()
        {

        }
        public Entity(int id)
        {
            this.id = id;
        }
    }
}
