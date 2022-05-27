using BibliotecaAppGui.Models;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaAppGui.Utils.orm
{
    public class CarteOrm : ClassMap<Carte>
    {
        CarteOrm()
        {
            Id(x => x.id).Column("id");
            Map(x => x.nume).Column("nume");
            Map(x => x.autor).Column("autor");

            Table("Carte");
        }
    }
}
