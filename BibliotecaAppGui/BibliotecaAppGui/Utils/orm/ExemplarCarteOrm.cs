using BibliotecaAppGui.Models;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaAppGui.Utils.orm
{
    public class ExemplarCarteOrm : ClassMap<ExemplarCarte>
    {
        ExemplarCarteOrm()
        {
            Id(x => x.id).Column("id");
            Map(x => x.cod_unic).Column("cod_unic");
            Map(x => x.data_rezervare).Column("data_rezervare");
            Map(x => x.calitate).Column("calitate").CustomType<Calitate>();
            Map(x => x.stareRetur).Column("stare_retur").CustomType<StareRetur>();
            References(x => x.carte).Column("id_carte");
            References(x => x.abonat).Column("id_abonat");
            Table("ExemplarCarte");
        }
    }
}
