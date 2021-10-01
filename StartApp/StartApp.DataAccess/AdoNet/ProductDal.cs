using StartApp.Entities.Concrete;
using StartApp.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace StartApp.DataAccess.AdoNet
{
    public class ProductDal
    {
        private string _connectionString;

        public ProductDal(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<ProductDto> GetAll()
        {
            string innerquery = string.Format("SELECT Products.ProductID, Products.ProductName, Suppliers.CompanyName ,Categories.CategoryName, Products.QuantityPerUnit ,Products.UnitPrice, Products.SupplierID, Products.CategoryID FROM (dbo.Products INNER JOIN Categories ON Products.CategoryID = Categories.CategoryID  INNER JOIN Suppliers ON Products.SupplierID = Suppliers.SupplierID )");
            List<ProductDto> products = new List<ProductDto>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            using (SqlCommand command = new SqlCommand(innerquery, connection))
            {
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        products.Add(new ProductDto
                        {
                            ProductID = reader.GetInt32(0),
                            ProductName = reader.GetString(1),
                            CompanyName = reader.GetString(2),
                            Category = reader.GetString(3),
                            QuantityPerUnit = reader[4] == DBNull.Value || reader[4] == null ? string.Empty : reader.GetString(4), // reader["QuantityPerUnit"]?.ToString(),
                            UnitPrice = reader[5] == DBNull.Value || reader[5] == null ? 0 : reader.GetDecimal(5),
                            SupplierID = reader.GetInt32(6),
                            CategoryID = reader.GetInt32(7),
                        });

                    }
                }
            }

            return products;
        }

        public bool ExistsByProductName(string productName)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Products WHERE LOWER(ProductName) = LOWER(@ProductName)", connection))
                {
                    cmd.Parameters.AddWithValue("@ProductName", productName);
                    return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                }
            }
        }

        public void Create(Product product)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand addCommand = new SqlCommand("INSERT INTO Products(ProductName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice) VALUES(@ProductName, @SupplierID, @CategoryID, @QuantityPerUnit, @UnitPrice)", connection))
                {
                    addCommand.Parameters.AddWithValue("@ProductName", product.ProductName);
                    addCommand.Parameters.AddWithValue("@SupplierID", product.SupplierID);
                    addCommand.Parameters.AddWithValue("@CategoryID", product.CategoryID);
                    addCommand.Parameters.AddWithValue("@QuantityPerUnit", product.QuantityPerUnit);
                    addCommand.Parameters.AddWithValue("@UnitPrice", product.UnitPrice);
                    addCommand.ExecuteNonQuery();
                }
            }
        }

        public void Update(Product product)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand addCommand = new SqlCommand("UPDATE Products SET ProductName=@ProductName, SupplierID=@SupplierID, CategoryID=@CategoryID, QuantityPerUnit=@QuantityPerUnit, UnitPrice=@UnitPrice WHERE ProductID=@ProductID", connection))
                {
                    addCommand.Parameters.AddWithValue("@ProductName", product.ProductName);
                    addCommand.Parameters.AddWithValue("@SupplierID", product.SupplierID);
                    addCommand.Parameters.AddWithValue("@CategoryID", product.CategoryID);
                    addCommand.Parameters.AddWithValue("@QuantityPerUnit", product.QuantityPerUnit);
                    addCommand.Parameters.AddWithValue("@UnitPrice", product.UnitPrice);
                    addCommand.Parameters.AddWithValue("@ProductID", product.ProductID);
                    addCommand.ExecuteNonQuery();
                }
            }
        }

        public void Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM [Order Details] WHERE ProductID=@ProductID", connection);
                cmd.Parameters.AddWithValue("@ProductID", id);
                cmd.ExecuteNonQuery();

                cmd.CommandText = "DELETE FROM Products WHERE ProductID=@ProductID";
                cmd.ExecuteNonQuery();
            }
        }
    }
}