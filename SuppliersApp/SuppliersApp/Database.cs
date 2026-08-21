using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;

namespace SuppliersApp
{
    class Database
    {
        public const string connectionString =
            "Data Source = localhost/orcl; User Id = C##User1; Password = Oracle123456;";

        // Open an Oracle DB connection
        public static OracleConnection OpenConnection()
        {
            OracleConnection conn =
                new OracleConnection(Database.connectionString);

            conn.Open();

            return conn;
        }

        public static DataSet ExecuteMultiRowQuery(string query)
        {
            // Open a connection to an Oracle database
            OracleConnection conn = OpenConnection();

            OracleCommand cmd = new OracleCommand(query, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();


            da.Fill(ds);

            conn.Close();

            return ds;
        }

        public static DataRow ExecuteSingleRowQuery(string query)
        {
            // Open a connection to an Oracle database
            OracleConnection conn = OpenConnection();

            OracleCommand cmd = new OracleCommand(query, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataTable dt = new DataTable();


            da.Fill(dt);

            conn.Close();

            if (dt.Rows.Count > 0)
                return dt.Rows[0];
            else
                return null;
        }

        public static void ExecuteNonQuery(string query)
        {
            OracleConnection conn = OpenConnection();

            OracleCommand cmd = new OracleCommand(query, conn);

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public static int GetNextID(string tableName, string primaryKeyColumn)
        {
            // Define the SQL query
            string sqlQuery =
                "SELECT NVL(MAX(" + primaryKeyColumn + "), 0) + 1 " +
                "FROM " + tableName;

            // Execute the query
            DataRow row = ExecuteSingleRowQuery(sqlQuery);

            // Return the next ID
            return Convert.ToInt32(row[0]);
        }
    }
}