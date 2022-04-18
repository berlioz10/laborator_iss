using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace BibliotecaAppGui.Utils
{
    public class DbUtils
    {
        private IDbConnection instance = null;
        private ConnectionStringSettings settings = null;

        public static void addWithValue(IDbCommand comm, String parameter, object value)
        {
            IDbDataParameter param = comm.CreateParameter();
            param.Value = value;
            param.ParameterName = parameter;
            comm.Parameters.Add(param);
        }
        public DbUtils(ConnectionStringSettings settings)
        {
            this.settings = settings;

            if (settings != null)
                instance = GetConnection();
            else
                throw new Exception("App.Config does not have the database accordingly");
            
        }

        public IDbConnection GetConnection()
        {
            if (instance == null)
                CreateConnection();
            Console.WriteLine(instance.ToString());
            return instance;
        }

        private void CreateConnection()
        {
            instance = new SQLiteConnection(this.settings.ConnectionString);
            instance.Open();
        }
    }
}
