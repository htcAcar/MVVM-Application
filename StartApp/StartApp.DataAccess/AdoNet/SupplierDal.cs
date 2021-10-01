using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using StartApp.Entities.Concrete;

namespace StartApp.DataAccess.AdoNet
{
    public class SupplierDal
    {
        private string _connectionString;

        public SupplierDal(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<Supplier> GetAll()
        {
            List<Supplier> suppliers = new List<Supplier>();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Suppliers", connection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    suppliers.Add(new Supplier
                    {
                        SupplierID = reader.GetInt32(0),
                        CompanyName = reader.GetString(1),
                        ContactName = reader[2] == DBNull.Value || reader[2] == null ? string.Empty : reader.GetString(2),
                        ContactTitle = reader[3] == DBNull.Value || reader[3] == null ? string.Empty : reader.GetString(3),
                        Address = reader[4] == DBNull.Value || reader[4] == null ? string.Empty : reader.GetString(4),
                        City = reader[5] == DBNull.Value || reader[5] == null ? string.Empty : reader.GetString(5),
                        Region = reader[6] == DBNull.Value || reader[6] == null ? string.Empty : reader.GetString(6),
                        PostalCode = reader[7] == DBNull.Value || reader[7] == null ? string.Empty : reader.GetString(7),
                        Country = reader[8] == DBNull.Value || reader[8] == null ? string.Empty : reader.GetString(8),
                        Phone = reader[9] == DBNull.Value || reader[9] == null ? string.Empty : reader.GetString(9),
                        Fax = reader[10] == DBNull.Value || reader[10] == null ? string.Empty : reader.GetString(10),
                        HomePage = reader[11] == DBNull.Value || reader[11] == null ? string.Empty : reader.GetString(11),
                    });
                }
            }

            return suppliers;
        }

        public bool ExistsByProductName(string companyName)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Suppliers WHERE LOWER(CompanyName) = LOWER(@CompanyName)", connection))
                {
                    cmd.Parameters.AddWithValue("@CompanyName", companyName);
                    return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                }
            }
        }

        public void Create(Supplier supplier)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand addCommand = new SqlCommand("INSERT INTO Suppliers(CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country, Phone, Fax, HomePage) VALUES(@CompanyName, @ContactName, @ContactTitle, @Address, @City, @Region, @PostalCode, @Country, @Phone, @Fax, @HomePage)", connection))
                {
                    addCommand.Parameters.AddWithValue("@CompanyName", supplier.CompanyName);
                    addCommand.Parameters.AddWithValue("@ContactName", supplier.ContactName);
                    addCommand.Parameters.AddWithValue("@ContactTitle", supplier.ContactTitle);
                    addCommand.Parameters.AddWithValue("@Address", supplier.Address);
                    addCommand.Parameters.AddWithValue("@City", supplier.City);
                    addCommand.Parameters.AddWithValue("@Region", supplier.Region);
                    addCommand.Parameters.AddWithValue("@PostalCode", supplier.PostalCode);
                    addCommand.Parameters.AddWithValue("@Country", supplier.Country);
                    addCommand.Parameters.AddWithValue("@Phone", supplier.Phone);
                    addCommand.Parameters.AddWithValue("@Fax", supplier.Fax);
                    addCommand.Parameters.AddWithValue("@HomePage", supplier.HomePage);
                    addCommand.ExecuteNonQuery();
                }
            }
        }

        public void Update(Supplier supplier)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand addCommand = new SqlCommand("UPDATE Suppliers SET CompanyName=@CompanyName, ContactName=@ContactName, ContactTitle=@ContactTitle, Address=@Address, City=@City, Region=@Region, PostalCode=@PostalCode, Country=@Country, Phone=@Phone, Fax=@Fax, HomePage=@HomePage WHERE SupplierID=@SupplierID", connection))
                {
                    addCommand.Parameters.AddWithValue("@CompanyName", supplier.CompanyName);
                    addCommand.Parameters.AddWithValue("@ContactName", supplier.ContactName);
                    addCommand.Parameters.AddWithValue("@ContactTitle", supplier.ContactTitle);
                    addCommand.Parameters.AddWithValue("@Address", supplier.Address);
                    addCommand.Parameters.AddWithValue("@City", supplier.City);
                    addCommand.Parameters.AddWithValue("@Region", supplier.Region);
                    addCommand.Parameters.AddWithValue("@PostalCode", supplier.PostalCode);
                    addCommand.Parameters.AddWithValue("@Country", supplier.Country);
                    addCommand.Parameters.AddWithValue("@Phone", supplier.Phone);
                    addCommand.Parameters.AddWithValue("@Fax", supplier.Fax);
                    addCommand.Parameters.AddWithValue("@HomePage", supplier.HomePage);
                    addCommand.Parameters.AddWithValue("@SupplierID", supplier.SupplierID);
                    addCommand.ExecuteNonQuery();
                }
            }
        }

        public void Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM [Products] WHERE SupplierID=@SupplierID", connection);
                cmd.Parameters.AddWithValue("@SupplierID", id);
                cmd.ExecuteNonQuery();              
                cmd.CommandText = "DELETE FROM Suppliers WHERE SupplierID=@SupplierID";
                cmd.ExecuteNonQuery();
            }
        }
    }
}
