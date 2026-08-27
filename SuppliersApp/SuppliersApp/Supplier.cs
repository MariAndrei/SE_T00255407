using System;
using System.Data;

namespace SuppliersApp
{
    public class Supplier
    {
        public int SupplierID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Manufacturer { get; set; }

        public Supplier() : this(0, "", "", "", "")
        {
        }

        public Supplier(int supplierID, string name, string email,
                        string phone, string manufacturer)
        {
            SupplierID = supplierID;
            Name = name;
            Email = email;
            Phone = phone;
            Manufacturer = manufacturer;
        }

        public static DataSet GetAllSuppliers()
        {
            string sqlQuery =
                "SELECT SupplierID, Name, Email, Phone, Manufacturer " +
                "FROM Supplier ORDER BY SupplierID";

            return Database.ExecuteMultiRowQuery(sqlQuery);
        }

        public static Supplier GetSupplier(int id)
        {
            string sqlQuery =
                "SELECT SupplierID, Name, Email, Phone, Manufacturer " +
                "FROM Supplier WHERE SupplierID = " + id;

            DataRow row = Database.ExecuteSingleRowQuery(sqlQuery);

            if (row != null)
            {
                return new Supplier(
                    Convert.ToInt32(row["SupplierID"]),
                    row["Name"].ToString(),
                    row["Email"].ToString(),
                    row["Phone"].ToString(),
                    row["Manufacturer"].ToString()
                );
            }

            return null;
        }

        public void AddSupplier()
        {
            string sqlQuery =
                "INSERT INTO Supplier VALUES(" +
                SupplierID + ",'" +
                Name + "','" +
                Email + "','" +
                Phone + "','" +
                Manufacturer + "')";

            Database.ExecuteNonQuery(sqlQuery);
        }

        public void UpdateSupplier()
        {
            string sqlQuery =
                "UPDATE Supplier SET " +
                "Name='" + Name + "'," +
                "Email='" + Email + "'," +
                "Phone='" + Phone + "'," +
                "Manufacturer='" + Manufacturer + "' " +
                "WHERE SupplierID=" + SupplierID;

            Database.ExecuteNonQuery(sqlQuery);
        }

        public static DataSet FindSupplier(string name)
        {
            string sqlQuery =
                "SELECT SupplierID, Name, Email, Phone, Manufacturer " +
                "FROM Supplier " +
                "WHERE Name LIKE '%" + name + "%' " +
                "ORDER BY Name";

            return Database.ExecuteMultiRowQuery(sqlQuery);
        }

        public static int GetNextSupplierID()
        {
            return Database.GetNextID("Supplier", "SupplierID");
        }
    }
}