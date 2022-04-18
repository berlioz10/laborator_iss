using BibliotecaAppGui.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaAppGui.Repo
{
    public interface AbonatInterfaceRepository : IRepository<Abonat>
    {
        Abonat validateDatas(String cod_unic);
        void addWithBibliotecar(Abonat abonat, int id_bibilotecar);
    }
}
