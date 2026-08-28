using System.Windows.Forms;
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
            using (OracleConnection conn = OpenConnection())
            {
                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    using (OracleDataAdapter da = new OracleDataAdapter(cmd))
                    {
                        DataSet ds = new DataSet();

                        da.Fill(ds);

                        return ds;
                    }
                }
            }
        }

        public static DataRow ExecuteSingleRowQuery(string query)
        {
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
            using (OracleConnection conn = OpenConnection())
            {
                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static int GetNextID(string tableName, string primaryKeyColumn)
        {
            string sqlQuery =
                "SELECT NVL(MAX(" + primaryKeyColumn + "), 0) + 1 " +
                "FROM " + tableName;

            DataRow row = ExecuteSingleRowQuery(sqlQuery);

            return Convert.ToInt32(row[0]);
        }
    }
}