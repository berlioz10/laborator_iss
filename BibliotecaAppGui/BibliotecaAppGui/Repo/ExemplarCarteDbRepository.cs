using BibliotecaAppGui.Models;
using BibliotecaAppGui.Utils;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Data;
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

        public void add_carte_rezervat(ExemplarCarte exemplarCarte, Abonat abonat)
        {
            IDbConnection con = dbUtils.GetConnection();

            try
            {
                using (var comm = con.CreateCommand())
                {
                    comm.CommandText = "UPDATE ExemplarCarte " +
                        "SET " +
                        "id_abonat = @id_abonat, " +
                        "stare_retur = 2, " +
                        "data_rezervare = @data_rezervare " +
                        "where id = @id_exemplar_carte";

                    DbUtils.addWithValue(comm, "@id_abonat", abonat.id);
                    DbUtils.addWithValue(comm, "@data_rezervare", DateTime.Now);
                    DbUtils.addWithValue(comm, "@id_exemplar_carte", exemplarCarte.id);

                    comm.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void return_carte_rezervat(ExemplarCarte exemplarCarte)
        {
            IDbConnection con = dbUtils.GetConnection();

            try
            {
                using (var comm = con.CreateCommand())
                {
                    comm.CommandText = "UPDATE ExemplarCarte " +
                        "SET " +
                        "stare_retur = 1 " +
                        "where id = @id_exemplar_carte";

                    DbUtils.addWithValue(comm, "@id_exemplar_carte", exemplarCarte.id);

                    comm.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public IList<ExemplarCarte> find_all()
        {
            throw new NotImplementedException();
        }

        public IList<ExemplarCarte> find_all_possible()
        {
            IList<ExemplarCarte> ret_list = new List<ExemplarCarte>();
            ISession session = NHibernateHelper.GetCurrentSession();
            try
            {
                using (ITransaction tx = session.BeginTransaction())
                {
                    var exemplare = from el in session.Query<ExemplarCarte>()
                                    where el.stareRetur == StareRetur.RETURNAT
                                    select el;


                    foreach (var el in exemplare)
                    {
                        ret_list.Add(el);
                    }
                    tx.Commit();
                }
            }
            finally
            {
                NHibernateHelper.CloseSession();
            }
            return ret_list;
        }

        public IList<ExemplarCarte> find_all_abonat(Abonat abonat)
        {
            IList<ExemplarCarte> ret_list = new List<ExemplarCarte>();
            ISession session = NHibernateHelper.GetCurrentSession();
            try
            {
                using (ITransaction tx = session.BeginTransaction())
                {
                    var exemplare = from el in session.Query<Abonat>()
                                    where el.cod_unic == abonat.cod_unic
                                    select el;



                    foreach (var el in exemplare)
                    {
                        abonat = el;
                    }
                    if (abonat.rezervate == null)
                        ret_list = null;
                    else
                        ret_list = abonat.rezervate;
                    tx.Commit();
                }
            }
            finally
            {
                NHibernateHelper.CloseSession();
            }
            return ret_list;
        }

        public ExemplarCarte find_by_cod_unic(string codig)
        {
            ExemplarCarte exemplarCarte = null;
            ISession session = NHibernateHelper.GetCurrentSession();
            try
            {
                using (ITransaction tx = session.BeginTransaction())
                {
                    var exemplare = from el in session.Query<ExemplarCarte>()
                                    where el.cod_unic == codig
                                    select el;


                    foreach (var el in exemplare)
                    {
                        exemplarCarte = el;
                    }
                    tx.Commit();
                }
            }
            finally
            {
                NHibernateHelper.CloseSession();
            }
            return exemplarCarte;
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

        public void put_carte_nerezervat(ExemplarCarte exemplarCarte, Abonat abonat)
        {
            throw new NotImplementedException();
        }
    }
}
