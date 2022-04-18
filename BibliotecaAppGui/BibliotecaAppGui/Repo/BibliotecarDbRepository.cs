using BibliotecaAppGui.Models;
using BibliotecaAppGui.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaAppGui.Repo
{
    public class BibliotecarDbRepository : BibliotecarInterfaceRepository
    {
        private DbUtils dbUtils;

        public BibliotecarDbRepository(DbUtils dbUtils)
        {
            this.dbUtils = dbUtils;
        }

        public void add(Bibliotecar entity)
        {
            throw new NotImplementedException();
        }

        public Bibliotecar FindByCodUnic(string cod_unic)
        {
            IDbConnection con = dbUtils.GetConnection();
            try
            {
                using (var comm = con.CreateCommand())
                {
                    comm.CommandText = "SELECT id, name from Bibliotecar WHERE cod_unic = @cod_unic";
                    DbUtils.addWithValue(comm, "@cod_unic", cod_unic);
                    using (var dr = comm.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            return new Bibliotecar(
                                dr.GetInt32(0), cod_unic, dr.GetString(1));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


            throw new Exception("Acest cod unic este inexistent!");
        }

        public IList<Bibliotecar> find_all()
        {
            throw new NotImplementedException();
        }

        public Bibliotecar find_by_id(int id)
        {
            throw new NotImplementedException();
        }

        public void remove(int id)
        {
            throw new NotImplementedException();
        }

        public void update(Bibliotecar entity)
        {
            throw new NotImplementedException();
        }
    }
}
