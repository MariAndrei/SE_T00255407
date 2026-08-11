using System;
using System.Data;

namespace SuppliersApp
{
    public class Sale
    {
        public int SaleID { get; set; }
        public int StockID { get; set; }
        public int QuantitySold { get; set; }
        public decimal TotalAmount { get; set; }
        public DateTime SaleDate { get; set; }

        public Sale() : this(0, 0, 0, 0, DateTime.Now) { }

        public Sale(int saleID, int stockID, int quantitySold, decimal totalAmount, DateTime saleDate)
        {
            SaleID = saleID;
            StockID = stockID;
            QuantitySold = quantitySold;
            TotalAmount = totalAmount;
            SaleDate = saleDate;
        }

        public void AddSale()
        {
            string formattedDate = SaleDate.ToString("dd-MMM-yyyy");

            string sqlQuery = "INSERT INTO Sales VALUES(" +
                SaleID + "," +
                StockID + "," +
                QuantitySold + "," +
                TotalAmount + ",'" +
                formattedDate + "')";

            Database.ExecuteNonQuery(sqlQuery);
        }

        public static DataSet GetAllSales()
        {
            string sqlQuery = "SELECT SaleID, StockID, QuantitySold, TotalAmount, SaleDate FROM Sales ORDER BY SaleDate DESC";
            return Database.ExecuteMultiRowQuery(sqlQuery);
        }

        public static int GetNextSaleID()
        {
            return Database.GetNextID("Sales", "SaleID");
        }
    }
}