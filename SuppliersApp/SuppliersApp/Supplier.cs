using System;
using System.Data;

namespace SuppliersApp
{
    public class Supplier
    {
        public int SuppID { get; set; }
        public string Name { get; set; }

        // Keeping these names so your existing forms still work
        public string Email { get; set; }
        public string Phone { get; set; }

        public string Manufacturer { get; set; }

        public Supplier() : this(0, "", "", "", "")
        {
        }

        public Supplier(
            int supplierID,
            string name,
            string email,
            string phone,
            string manufacturer)
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
                "SELECT SuppID, Name, PhoneNo, Address, Manufacturer " +
                "FROM Suppliers " +
                "WHERE SuppID = " + id;

            DataRow row = Database.ExecuteSingleRowQuery(sqlQuery);

            if (row != null)
            {
                return new Supplier(
                    Convert.ToInt32(row["SuppID"]),
                    row["Name"].ToString(),

                    // Email textbox/property currently stores Address
                    row["Address"].ToString(),

                    // Phone property stores PhoneNo
                    row["PhoneNo"].ToString(),

                    row["Manufacturer"].ToString()
                );
            }

            return null;
        }

        public void AddSupplier()
        {
            string sqlQuery =
                "INSERT INTO Suppliers " +
                "(SuppID, Name, PhoneNo, Address, Manufacturer) VALUES (" +
                SuppID + ",'" +
                Name + "','" +
                Phone + "','" +
                Email + "','" +
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
                "UPDATE Suppliers SET " +
                "Name='" + Name + "'," +
                "PhoneNo='" + Phone + "'," +
                "Address='" + Email + "'," +
                "Manufacturer='" + Manufacturer + "' " +
                "WHERE SuppID=" + SuppID;

            Database.ExecuteNonQuery(sqlQuery);
        }

        public static DataSet FindSupplier(string name)
        {
            string sqlQuery =
                "SELECT SuppID, Name, PhoneNo, Address, Manufacturer " +
                "FROM Suppliers " +
                "WHERE UPPER(Name) LIKE UPPER('%" + name + "%') " +
                "ORDER BY Name";

            return Database.ExecuteMultiRowQuery(sqlQuery);
        }

        public static int GetNextSupplierID()
        {
            return Database.GetNextID("Suppliers", "SuppID");
        }
    }
}