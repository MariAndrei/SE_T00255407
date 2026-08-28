using System;
using System.Data;

namespace SuppliersApp
{
    public class Sale
    {
        // Properties
        public int SaleID { get; set; }
        public int StockID { get; set; }
        public int Qty { get; set; }
        public decimal Total { get; set; }
        public DateTime SaleDate { get; set; }

        public Sale() : this(0, 0, 0, 0, DateTime.Now)
        {
        }

        public Sale(int saleID, int stockID, int qty,
                    decimal total, DateTime saleDate)
        {
            SaleID = saleID;
            StockID = stockID;
            Qty = qty;
            Total = total;
            SaleDate = saleDate;
        }

        // ADD SALE
        public void AddSale()
        {
            string formattedDate = SaleDate.ToString("dd-MMM-yyyy");

            string sqlQuery =
                "INSERT INTO Sales (SaleID, StockID, Qty, Total, SaleDate) VALUES (" +
                SaleID + "," +
                StockID + "," +
                Qty + "," +
                Total + ",'" +
                formattedDate + "')";

            Database.ExecuteNonQuery(sqlQuery);
        }

        public void RemoveSale()
        {
            string sqlQuery =
                "DELETE FROM Sales " +
                "WHERE SaleID = " + SaleID;

            Database.ExecuteNonQuery(sqlQuery);
        }

        // GET ALL SALES
        public static DataSet GetAllSales()
        {
            string sqlQuery =
                "SELECT SaleID, StockID, Qty, Total, SaleDate " +
                "FROM Sales ORDER BY SaleID";

            return Database.ExecuteMultiRowQuery(sqlQuery);
        }

        // GET ONE SALE
        public static Sale GetSale(int id)
        {
            string sqlQuery =
                "SELECT SaleID, StockID, Qty, Total, SaleDate " +
                "FROM Sales WHERE SaleID = " + id;

            DataRow row = Database.ExecuteSingleRowQuery(sqlQuery);

            if (row != null)
            {
                return new Sale(
                    Convert.ToInt32(row["SaleID"]),
                    Convert.ToInt32(row["StockID"]),
                    Convert.ToInt32(row["Qty"]),
                    Convert.ToDecimal(row["Total"]),
                    Convert.ToDateTime(row["SaleDate"])
                );
            }

            return null;
        }

        // FIND SALE
        public static DataSet FindSale(string search)
        {
            string sqlQuery =
                "SELECT SaleID, StockID, Qty, Total, SaleDate " +
                "FROM Sales " +
                "WHERE SaleID LIKE '%" + search + "%' " +
                "ORDER BY SaleID";

            return Database.ExecuteMultiRowQuery(sqlQuery);
        }

        // UPDATE SALE
        public void UpdateSale()
        {
            string formattedDate = SaleDate.ToString("dd-MMM-yyyy");

            string sqlQuery =
                "UPDATE Sales SET " +
                "StockID = " + StockID + "," +
                "Qty = " + Qty + "," +
                "Total = " + Total + "," +
                "SaleDate = '" + formattedDate + "' " +
                "WHERE SaleID = " + SaleID;

            Database.ExecuteNonQuery(sqlQuery);
        }

        // GET NEXT SALE ID
        public static int GetNextSaleID()
        {
            return Database.GetNextID("Sales", "SaleID");
        }
    }
}