using System;
using System.Data;
using System.Diagnostics;
using Oracle.ManagedDataAccess.Client;

namespace ProductApp
{
    public class Stock
    {
        // Properties
        public int StockID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int StockQty { get; set; }

        // Default constructor
        public Stock() : this(0, "", 0, 0)
        {

        }

        // Constructor
        public Stock(int stockID, string description, decimal price, int stockQty)
        {
            StockID = stockID;
            Description = description;
            Price = price;
            StockQty = stockQty;
        }

        public override string ToString()
        {
            return "Stock ID: " + StockID +
                   "\tDescription: " + Description +
                   "\tPrice: " + Price +
                   "\tQuantity: " + StockQty;
        }

        // Return all stock
        public static DataSet GetAllStock()
        {
            string sqlQuery =
                "SELECT StockID, Description, Price, StockQty " +
                "FROM Stock ORDER BY StockID";

            return Database.ExecuteMultiRowQuery(sqlQuery);
        }

        // Return one stock item
        public static Stock GetStock(int id)
        {
            string sqlQuery =
                "SELECT * FROM Stock WHERE StockID = " + id;

            OracleDataReader dr =
                Database.ExecuteSingleRowQuery(sqlQuery);

            dr.Read();

            string description = dr.GetString(1);
            decimal price = dr.GetDecimal(2);
            int qty = dr.GetInt32(3);

            dr.Close();

            return new Stock(id, description, price, qty);
        }

        // Add stock
        public void AddStock()
        {
            Debug.WriteLine(this);

            string sqlQuery =
                "INSERT INTO Stock VALUES(" +
                StockID + ",'" +
                Description + "'," +
                Price + "," +
                StockQty + ")";

            Database.ExecuteNonQuery(sqlQuery);
        }

        // Update stock
        public void UpdateStock()
        {
            string sqlQuery =
                "UPDATE Stock SET " +
                "Description='" + Description + "'," +
                "Price=" + Price + "," +
                "StockQty=" + StockQty +
                " WHERE StockID=" + StockID;

            Database.ExecuteNonQuery(sqlQuery);
        }

        // Search by description
        public static DataSet FindStock(string description)
        {
            string sqlQuery =
                "SELECT StockID, Description, Price, StockQty " +
                "FROM Stock " +
                "WHERE Description LIKE '%" + description + "%' " +
                "ORDER BY Description";

            return Database.ExecuteMultiRowQuery(sqlQuery);
        }

        // Next Stock ID
        public static int GetNextStockID()
        {
            string sqlQuery =
                "SELECT MAX(StockID) FROM Stock";

            OracleDataReader dr =
                Database.ExecuteSingleRowQuery(sqlQuery);

            int nextID;

            dr.Read();

            if (dr.IsDBNull(0))
                nextID = 1;
            else
                nextID = dr.GetInt32(0) + 1;

            dr.Close();

            return nextID;
        }
    }
}