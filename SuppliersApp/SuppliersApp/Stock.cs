using System;
using System.Data;

namespace SuppliersApp
{
    public class Stock
    {
        public int StockID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int StockQty { get; set; }
        public int SupplierID { get; set; }

        public Stock() : this(0, "", 0, 0, 0) { }

        public Stock(int stockID, string description, decimal price, int stockQty, int supplierID = 0)
        {
            StockID = stockID;
            Description = description;
            Price = price;
            StockQty = stockQty;
            SupplierID = supplierID;
        }

        public static DataSet GetAllStock()
        {
            string sqlQuery = "SELECT StockID, Description, Price, StockQty, SupplierID FROM Stock ORDER BY StockID";
            return Database.ExecuteMultiRowQuery(sqlQuery);
        }

        public static Stock GetStock(int id)
        {
            string sqlQuery = "SELECT StockID, Description, Price, StockQty, SupplierID FROM Stock WHERE StockID = " + id;
            DataRow row = Database.ExecuteSingleRowQuery(sqlQuery);

            if (row != null)
            {
                int supplierId = row["SupplierID"] != DBNull.Value ? Convert.ToInt32(row["SupplierID"]) : 0;

                return new Stock(
                    Convert.ToInt32(row["StockID"]),
                    row["Description"].ToString(),
                    Convert.ToDecimal(row["Price"]),
                    Convert.ToInt32(row["StockQty"]),
                    supplierId
                );
            }
            return null;
        }

        public void AddStock()
        {
            string supplierValue = SupplierID > 0 ? SupplierID.ToString() : "NULL";

            string sqlQuery = "INSERT INTO Stock VALUES(" +
                StockID + ",'" +
                Description + "'," +
                Price + "," +
                StockQty + "," +
                supplierValue + ")";

            Database.ExecuteNonQuery(sqlQuery);
        }

        public void UpdateStock()
        {
            string supplierValue = SupplierID > 0 ? SupplierID.ToString() : "NULL";

            string sqlQuery = "UPDATE Stock SET " +
                "Description='" + Description + "'," +
                "Price=" + Price + "," +
                "StockQty=" + StockQty + "," +
                "SupplierID=" + supplierValue + " " +
                "WHERE StockID=" + StockID;

            Database.ExecuteNonQuery(sqlQuery);
        }

        public static DataSet FindStock(string description)
        {
            string sqlQuery = "SELECT StockID, Description, Price, StockQty, SupplierID FROM Stock " +
                              "WHERE Description LIKE '%" + description + "%' ORDER BY Description";

            return Database.ExecuteMultiRowQuery(sqlQuery);
        }

        public static int GetNextStockID()
        {
            return Database.GetNextID("Stock", "StockID");
        }
    }
}