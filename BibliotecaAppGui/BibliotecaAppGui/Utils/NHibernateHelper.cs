using BibliotecaAppGui.Utils.orm;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaAppGui.Utils
{
    public class NHibernateHelper
    {
        private static readonly ISessionFactory _sessionFactory;
        private static String _fileName;
        static NHibernateHelper()
        {
            _sessionFactory = FluentConfigure();
        }

        public static ISession GetCurrentSession()
        {
            return _sessionFactory.OpenSession();
        }
        public static void CloseSession()
        {
            _sessionFactory.Close();
        }
        public static void CloseSessionFactory()
        {
            if (_sessionFactory != null)
            {
                _sessionFactory.Close();
            }
        }

        public static ISessionFactory FluentConfigure()
        {
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["sqliteDBFile"];
            _fileName = settings.ConnectionString;
            return Fluently.Configure()
                //which database
                .Database(SQLiteConfiguration.Standard.UsingFile(_fileName))
                //find/set the mappings
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<ExemplarCarteOrm>())
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<CarteOrm>())
                //.Mappings(m => m.FluentMappings.AddFromAssembly(Assembly.GetExecutingAssembly()))
                .BuildSessionFactory();
        }
    }
}
