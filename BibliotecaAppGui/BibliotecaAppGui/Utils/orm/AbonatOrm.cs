using BibliotecaAppGui.Models;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaAppGui.Utils.orm
{
    public class AbonatOrm : ClassMap<Abonat>
    {
        public AbonatOrm()
        {
            Id(x => x.id).Column("id");
            Map(x => x.cod_unic).Column("cod_unic");
            Map(x => x.nume).Column("nume");
            Map(x => x.adresa).Column("adresa");
            Map(x => x.cnp).Column("cnp");

            HasMany(x => x.rezervate).Table("ExemplarCarte");

            Table("Abonat");

        }
    }
}
