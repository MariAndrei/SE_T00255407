using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace SuppliersApp
{
    class Database
    {
        private const string connectionString =
        "Data Source=localhost/orcl;User Id=C##User1;Password=Oracle123456;";

        public static OracleConnection OpenConnection()
        {
            OracleConnection connection = new OracleConnection(connectionString);
            connection.Open();
            return connection;
        }

        public static DataSet ExecuteMultiRowQuery(string query)
        {
                       using (OracleConnection connection = OpenConnection())
            {
                OracleDataAdapter adapter = new OracleDataAdapter(query, connection);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                return dataSet;
            }
        }

        public static OracleDataReader ExecuteSingleRowQuery(string query)
        {
                        OracleConnection connection = OpenConnection();
            OracleCommand command = new OracleCommand(query, connection);
            return command.ExecuteReader(CommandBehavior.CloseConnection);
        }

        public static void ExecuteNonQuery(string query)
        {
                        using (OracleConnection connection = OpenConnection())
            {
                OracleCommand command = new OracleCommand(query, connection);
                command.ExecuteNonQuery();
            }
        }
    }
}
