using System;
using System.Data;
using System.Diagnostics;

namespace SuppliersApp
{
    public class Revenue
    {
        // Properties
        public int RevenueID { get; set; }
        public int SaleID { get; set; }
        public decimal RevenueAmount { get; set; }
        public DateTime RevenueDate { get; set; }

        // No-argument constructor
        public Revenue() : this(0, 0, 0, DateTime.Now) { }

        // Full constructor
        public Revenue(int revenueID, int saleID,
                       decimal revenueAmount, DateTime revenueDate)
        {
            RevenueID = revenueID;
            SaleID = saleID;
            RevenueAmount = revenueAmount;
            RevenueDate = revenueDate;
        }

        // ToString()
        public override string ToString()
        {
            return "Revenue ID: " + RevenueID +
                   "\tSale ID: " + SaleID +
                   "\tRevenue Amount: " + RevenueAmount +
                   "\tRevenue Date: " + RevenueDate.ToShortDateString();
        }

        // Get all revenue
        public static DataSet GetAllRevenue()
        {
            string sqlQuery =
                "SELECT RevenueID, SaleID, RevenueAmount, RevenueDate " +
                "FROM Revenue ORDER BY RevenueDate DESC";

            return Database.ExecuteMultiRowQuery(sqlQuery);
        }

        // Get one revenue record
        public static Revenue GetRevenue(int id)
        {
            string sqlQuery =
                "SELECT RevenueID, SaleID, RevenueAmount, RevenueDate " +
                "FROM Revenue WHERE RevenueID = " + id;

            DataRow row = Database.ExecuteSingleRowQuery(sqlQuery);

            if (row != null)
            {
                return new Revenue(
                    Convert.ToInt32(row["RevenueID"]),
                    Convert.ToInt32(row["SaleID"]),
                    Convert.ToDecimal(row["RevenueAmount"]),
                    Convert.ToDateTime(row["RevenueDate"])
                );
            }

            return null;
        }

        // Add revenue
        public void AddRevenue()
        {
            Debug.WriteLine(this);

            string formattedDate = RevenueDate.ToString("yyyy-MM-dd");

            string sqlQuery =
                "INSERT INTO Revenue " +
                "(RevenueID, SaleID, RevenueAmount, RevenueDate) VALUES (" +
                RevenueID + "," +
                SaleID + "," +
                RevenueAmount + "," +
                "TO_DATE('" + formattedDate + "','YYYY-MM-DD'))";

            Database.ExecuteNonQuery(sqlQuery);
        }

        // Update revenue
        public void UpdateRevenue()
        {
            string formattedDate = RevenueDate.ToString("yyyy-MM-dd");

            string sqlQuery =
                "UPDATE Revenue SET " +
                "SaleID = " + SaleID + "," +
                "RevenueAmount = " + RevenueAmount + "," +
                "RevenueDate = TO_DATE('" + formattedDate + "','YYYY-MM-DD') " +
                "WHERE RevenueID = " + RevenueID;

            Database.ExecuteNonQuery(sqlQuery);
        }

        // Remove revenue
        public void RemoveRevenue()
        {
            string sqlQuery =
                "DELETE FROM Revenue " +
                "WHERE RevenueID = " + RevenueID;

            Database.ExecuteNonQuery(sqlQuery);
        }

        // Get next Revenue ID
        public static int GetNextRevenueID()
        {
            return Database.GetNextID("Revenue", "RevenueID");
        }

        // Get sales for cboSale
        public static DataSet GetSales()
        {
            string sqlQuery =
                "SELECT SaleID, StockID, Qty, SaleDate, Total " +
                "FROM Sales " +
                "ORDER BY SaleID";

            return Database.ExecuteMultiRowQuery(sqlQuery);
        }
    }
}