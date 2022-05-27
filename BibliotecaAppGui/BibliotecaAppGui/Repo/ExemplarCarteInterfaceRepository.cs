using BibliotecaAppGui.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaAppGui.Repo
{
    public interface ExemplarCarteInterfaceRepository : IRepository<ExemplarCarte>
    {
        IList<ExemplarCarte> find_all_possible();
        ExemplarCarte find_by_cod_unic(String codig);
        void add_carte_rezervat(ExemplarCarte exemplarCarte, Abonat abonat);
        IList<ExemplarCarte> find_all_abonat(Abonat abonat);
        void put_carte_nerezervat(ExemplarCarte exemplarCarte, Abonat abonat);
        void return_carte_rezervat(ExemplarCarte exemplarCarte);
    }
}
