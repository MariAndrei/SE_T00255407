using System;
using System.Data;

namespace SuppliersApp
{
    public class Supplier
    {
        public int SuppID { get; set; }
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
            SuppID = supplierID;
            Name = name;
            Email = email;
            Phone = phone;
            Manufacturer = manufacturer;
        }

        public static DataSet GetAllSuppliers()
        {
            string sqlQuery =
                "SELECT SuppID, Name, PhoneNo, Address, Manufacturer " +
                "FROM Suppliers " +
                "ORDER BY SuppID";

            return Database.ExecuteMultiRowQuery(sqlQuery);
        }

        public static Supplier GetSupplier(int id)
        {
            string sqlQuery =
                "SELECT SuppID, Name, Email, Phone, Manufacturer " +
                "FROM Supplier WHERE SuppID = " + id;

            DataRow row = Database.ExecuteSingleRowQuery(sqlQuery);

            if (row != null)
            {
                return new Supplier(
                    Convert.ToInt32(row["SuppID"]),
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
                SuppID + ",'" +
                Name + "','" +
                Email + "','" +
                Phone + "','" +
                Manufacturer + "')";

            Database.ExecuteNonQuery(sqlQuery);
        }

                public void RemoveSupplier()
        {
            string sqlQuery =
                "DELETE FROM Suppliers " +
                "WHERE SuppID = " + SuppID;

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
                "WHERE SuppID=" + SuppID;

            Database.ExecuteNonQuery(sqlQuery);
        }

        public static DataSet FindSupplier(string name)
        {
            string sqlQuery =
                "SELECT SuppID, Name, Email, Phone, Manufacturer " +
                "FROM Supplier " +
                "WHERE Name LIKE '%" + name + "%' " +
                "ORDER BY Name";

            return Database.ExecuteMultiRowQuery(sqlQuery);
        }

        public static int GetNextSupplierID()
        {
            return Database.GetNextID("Supplier", "SuppID");
        }


    }
}