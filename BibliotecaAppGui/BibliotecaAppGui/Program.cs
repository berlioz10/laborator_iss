using BibliotecaAppGui.Repo;
using BibliotecaAppGui.Utils;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaAppGui
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DbUtils dbUtils = new DbUtils(ConfigurationManager.ConnectionStrings["sqliteDB"]); 
            AbonatInterfaceRepository abonatRepo = new AbonatDbRepository(dbUtils);
            BibliotecarInterfaceRepository bibliotecarRepo = new BibliotecarDbRepository(dbUtils);
            ExemplarCarteInterfaceRepository exemplarCarteRepo = new ExemplarCarteDbRepository(dbUtils);
            Application.Run(new MainBiblioteca(abonatRepo, bibliotecarRepo, exemplarCarteRepo));
        }
    }
}
