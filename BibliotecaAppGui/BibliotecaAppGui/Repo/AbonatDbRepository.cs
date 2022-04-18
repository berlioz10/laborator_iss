using BibliotecaAppGui.Models;
using BibliotecaAppGui.Utils;
using System;
using System.Collections.Generic;
using System.Data;

namespace BibliotecaAppGui.Repo
{
    public class AbonatDbRepository : AbonatInterfaceRepository
    {
        private DbUtils dbUtils;

        public AbonatDbRepository(DbUtils dbUtils)
        {
            this.dbUtils = dbUtils;
        }

        public void add(Abonat abonat)
        {
            // should not be added, instead use:
            // addWithBibliotecar()
        }

        public void addWithBibliotecar(Abonat abonat, int id_bibilotecar)
        {
            IDbConnection con = dbUtils.GetConnection();

            try
            {
                using (var comm = con.CreateCommand())
                {
                    comm.CommandText = "INSERT INTO Abonat(cod_unic, nume, adresa, cnp, id_bibliotecar) VALUES (@cod_unic, @nume, @adresa, @cnp, @id_bibliotecar)";
                    DbUtils.addWithValue(comm, "@cod_unic", abonat.cod_unic);
                    DbUtils.addWithValue(comm, "@nume", abonat.nume);
                    DbUtils.addWithValue(comm, "@adresa", abonat.adresa);
                    DbUtils.addWithValue(comm, "@cnp", abonat.cnp);
                    DbUtils.addWithValue(comm, "@id_bibliotecar", id_bibilotecar);

                    comm.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public IList<Abonat> find_all()
        {
            IDbConnection con = dbUtils.GetConnection();
            try
            {
                using (var comm = con.CreateCommand())
                {
                    comm.CommandText = "SELECT " +
                    "a.id, a.cod_unic, a.nume, a.adresa, a.cnp, " +
                    "ec.id, ec.cod_unic, ec.data_rezervare, ec.calitate, ec.stare_retur, " +
                    "c.id, c.nume, c.autor FROM abonat a " +
                    "LEFT JOIN ExemplarCarte ec on ec.id_abonat = a.id " +
                    "LEFT JOIN Carte c on ec.id_carte = c.id";

                    using (var dataR = comm.ExecuteReader())
                    {
                        Int32 id = -1;

                        IList<Abonat> abonati = new List<Abonat>();

                        while (dataR.Read())
                        {
                            if (id != dataR.GetInt32(0))
                            {
                                id = dataR.GetInt32(0);
                                abonati.Add(new Abonat(
                                        dataR.GetInt32(0),
                                        dataR.GetString(1),
                                        dataR.GetString(2),
                                        dataR.GetString(3),
                                        dataR.GetString(4),
                                        new List<ExemplarCarte>()
                                        ));

                                if (dataR.GetValue(5) != DBNull.Value)
                                {
                                    abonati[abonati.Count - 1].rezervate.Add(
                                    new ExemplarCarte(
                                        dataR.GetInt32(5),
                                        dataR.GetString(6),
                                        dataR.GetDateTime(7),
                                        CalitateHelp.transformNumberToCalitate(dataR.GetInt32(8)),
                                        StareReturHelp.transformNumberToStareRetur(dataR.GetInt32(9)),
                                        new Carte(
                                            dataR.GetInt32(10),
                                            dataR.GetString(11),
                                            dataR.GetString(12)
                                            )
                                        ));
                                }
                            }
                            else
                            {

                                if (dataR.GetValue(5) != DBNull.Value)
                                    abonati[abonati.Count - 1].rezervate.Add(
                                    new ExemplarCarte(
                                        dataR.GetInt32(5),
                                        dataR.GetString(6),
                                        dataR.GetDateTime(7),
                                        CalitateHelp.transformNumberToCalitate(dataR.GetInt32(8)),
                                        StareReturHelp.transformNumberToStareRetur(dataR.GetInt32(9)),
                                        new Carte(
                                            dataR.GetInt32(10),
                                            dataR.GetString(11),
                                            dataR.GetString(12)
                                            )
                                        ));
                            }
                        }
                        return abonati;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Abonat find_by_id(int id)
        {
            throw new NotImplementedException();
        }

        public void remove(int id)
        {
            throw new NotImplementedException();
        }

        public void update(Abonat entity)
        {
            throw new NotImplementedException();
        }

        public Abonat validateDatas(string cod_unic)
        {
            IDbConnection con = dbUtils.GetConnection();
            try
            {
                using (var comm = con.CreateCommand())
                {
                    comm.CommandText = "SELECT " +
                    "a.id, a.cod_unic, a.nume, a.adresa, a.cnp, " +
                    "ec.id, ec.cod_unic, ec.data_rezervare, ec.calitate, ec.stare_retur, " +
                    "c.id, c.nume, c.autor FROM abonat a " +
                    "LEFT JOIN ExemplarCarte ec on ec.id_abonat = a.id " +
                    "LEFT JOIN Carte c on ec.id_carte = c.id where a.cod_unic = @cod_unic";

                    DbUtils.addWithValue(comm, "@cod_unic", cod_unic);
                    IList<Abonat> abonati = new List<Abonat>();
                    using (var dataR = comm.ExecuteReader())
                    {
                        Abonat abonat = null;
                        bool ok = false;
                        while (dataR.Read())
                        {
                            if (ok == false)
                            {
                                ok = true;
                                abonat = new Abonat(
                                        dataR.GetInt32(0),
                                        dataR.GetString(1),
                                        dataR.GetString(2),
                                        dataR.GetString(3),
                                        dataR.GetString(4),
                                        new List<ExemplarCarte>()
                                    );

                                if (dataR.GetValue(5) != DBNull.Value)
                                    abonat.rezervate.Add(
                                    new ExemplarCarte(
                                        dataR.GetInt32(5),
                                        dataR.GetString(6),
                                        dataR.GetDateTime(7),
                                        CalitateHelp.transformNumberToCalitate(dataR.GetInt32(8)),
                                        StareReturHelp.transformNumberToStareRetur(dataR.GetInt32(9)),
                                        new Carte(
                                            dataR.GetInt32(10),
                                            dataR.GetString(11),
                                            dataR.GetString(12)
                                            )
                                        ));
                            }
                            else
                            {

                                if (dataR.GetValue(5) != DBNull.Value)
                                    abonat.rezervate.Add(
                                    new ExemplarCarte(
                                        dataR.GetInt32(5),
                                        dataR.GetString(6),
                                        dataR.GetDateTime(7),
                                        CalitateHelp.transformNumberToCalitate(dataR.GetInt32(8)),
                                        StareReturHelp.transformNumberToStareRetur(dataR.GetInt32(9)),
                                        new Carte(
                                            dataR.GetInt32(10),
                                            dataR.GetString(11),
                                            dataR.GetString(12)
                                            )
                                        ));
                            }

                        }

                        return abonat;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
