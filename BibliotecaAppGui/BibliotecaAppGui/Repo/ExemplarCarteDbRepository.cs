using BibliotecaAppGui.Models;
using BibliotecaAppGui.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaAppGui.Repo
{
    internal class ExemplarCarteDbRepository : ExemplarCarteInterfaceRepository
    {
        private DbUtils dbUtils;

        public ExemplarCarteDbRepository(DbUtils dbUtils)
        {
            this.dbUtils = dbUtils;
        }

        public void add(ExemplarCarte entity)
        {
            throw new NotImplementedException();
        }

        public IList<ExemplarCarte> find_all()
        {
            throw new NotImplementedException();
        }

        public ExemplarCarte find_by_id(int id)
        {
            throw new NotImplementedException();
        }

        public void remove(int id)
        {
            throw new NotImplementedException();
        }

        public void update(ExemplarCarte entity)
        {
            throw new NotImplementedException();
        }
    }
}
