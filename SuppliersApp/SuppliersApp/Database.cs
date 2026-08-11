using System;
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace SuppliersApp
{
    class Database
    {
        private const string ConnectionString =
            "Data Source=localhost:1521/orcl;User Id=C##User1;Password=Oracle123456;";

        public static OracleConnection OpenConnection()
        {
            OracleConnection connection = new OracleConnection(ConnectionString);
            connection.Open();
            return connection;
        }

        
        public static DataSet ExecuteMultiRowQuery(string query)
        {
            using (OracleConnection connection = OpenConnection())
            {
                using (OracleDataAdapter adapter = new OracleDataAdapter(query, connection))
                {
                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet);
                    return dataSet;
                }
            }
        }

        
        public static DataRow ExecuteSingleRowQuery(string query)
        {
            using (OracleConnection connection = OpenConnection())
            {
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    using (OracleDataAdapter adapter = new OracleDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt.Rows.Count > 0 ? dt.Rows[0] : null;
                    }
                }
            }
        }

        
        public static void ExecuteNonQuery(string query)
        {
            using (OracleConnection connection = OpenConnection())
            {
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        
        public static int GetNextID(string tableName, string primaryKeyColumn)
        {
            string sqlQuery = "SELECT NVL(MAX(" + primaryKeyColumn + "), 0) + 1 FROM " + tableName;
            DataRow row = ExecuteSingleRowQuery(sqlQuery);
            return Convert.ToInt32(row[0]);
        }
    }
}