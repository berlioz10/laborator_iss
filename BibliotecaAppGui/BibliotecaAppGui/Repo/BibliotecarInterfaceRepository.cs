using BibliotecaAppGui.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaAppGui.Repo
{
    public interface BibliotecarInterfaceRepository : IRepository<Bibliotecar>
    {
        Bibliotecar FindByCodUnic(string cod_unic);
    }
}
