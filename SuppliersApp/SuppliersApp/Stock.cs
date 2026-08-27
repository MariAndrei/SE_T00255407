using System;
using System.Data;
using System.Diagnostics;

namespace SuppliersApp
{
    public class Stock
    {
        // Properties
        public int StockID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int StockQty { get; set; }
        public int SuppID { get; set; }

        // No-argument constructor
        public Stock() : this(0, "", 0, 0, 0) { }

        // Full constructor
        public Stock(int stockID, string description, decimal price,
                     int stockQty, int suppID)
        {
            StockID = stockID;
            Description = description;
            Price = price;
            StockQty = stockQty;
            SuppID = suppID;
        }

        // ToString()
        public override string ToString()
        {
            return "Stock ID: " + StockID +
                   "\tDescription: " + Description +
                   "\tPrice: " + Price +
                   "\tQuantity: " + StockQty +
                   "\tSupplier ID: " + SuppID;
        }

        // Get all stock
        public static DataSet GetAllStock()
        {
            string sqlQuery =
                "SELECT StockID, Description, Price, StockQty, SuppID " +
                "FROM Stock ORDER BY StockID";

            return Database.ExecuteMultiRowQuery(sqlQuery);
        }

        // Get one stock item
        public static Stock GetStock(int id)
        {
            string sqlQuery =
                "SELECT StockID, Description, Price, StockQty, SuppID " +
                "FROM Stock WHERE StockID = " + id;

            DataRow row = Database.ExecuteSingleRowQuery(sqlQuery);

            if (row != null)
            {
                return new Stock(
                    Convert.ToInt32(row["StockID"]),
                    row["Description"].ToString(),
                    Convert.ToDecimal(row["Price"]),
                    Convert.ToInt32(row["StockQty"]),
                    Convert.ToInt32(row["SuppID"])
                );
            }

            return null;
        }

        // Add stock
        public void AddStock()
        {
            Debug.WriteLine(this);

            string sqlQuery =
                "INSERT INTO Stock " +
                "(StockID, Description, Price, StockQty, SuppID) VALUES (" +
                StockID + ",'" +
                Description + "'," +
                Price + "," +
                StockQty + "," +
                SuppID + ")";

            Database.ExecuteNonQuery(sqlQuery);
        }

        // Update stock
        public void UpdateStock()
        {
            string sqlQuery =
                "UPDATE Stock SET " +
                "Description = '" + Description + "'," +
                "Price = " + Price + "," +
                "StockQty = " + StockQty + "," +
                "SuppID = " + SuppID + " " +
                "WHERE StockID = " + StockID;

            Database.ExecuteNonQuery(sqlQuery);
        }

        // Remove stock
        public void RemoveStock()
        {
            string sqlQuery =
                "DELETE FROM Stock " +
                "WHERE StockID = " + StockID;

            Database.ExecuteNonQuery(sqlQuery);
        }

        // Search stock by description
        public static DataSet FindStock(string description)
        {
            string sqlQuery =
                "SELECT StockID, Description, Price, StockQty, SuppID " +
                "FROM Stock " +
                "WHERE Description LIKE '%" + description + "%' " +
                "ORDER BY Description";

            return Database.ExecuteMultiRowQuery(sqlQuery);
        }

        // Get next stock ID
        public static int GetNextStockID()
        {
            return Database.GetNextID("Stock", "StockID");
        }

        // Get suppliers for cboSupplier
        public static DataSet GetSuppliers()
        {
            string sqlQuery =
                "SELECT SuppID, Name " +
                "FROM Suppliers " +
                "ORDER BY Name";

            return Database.ExecuteMultiRowQuery(sqlQuery);
        }
    }
}