using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using StartApp.Entities.Concrete;

namespace StartApp.DataAccess.AdoNet
{
    public class CategoryDal
    {
        private string _connectionString;

        public CategoryDal(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<Category> GetAll()
        {
            List<Category> categories = new List<Category>();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT CategoryID, CategoryName, Description FROM Categories ", connection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    categories.Add(new Category
                    {
                        CategoryID = reader.GetInt32(0),
                        CategoryName = reader.GetString(1),
                        Description = reader.GetString(2)
                    });
                }
            }

            return categories;
        }
        public bool ExistsByProductName(string categoryName)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Categories WHERE LOWER(CategoryName) = LOWER(@CategoryName)", connection))
                {
                    cmd.Parameters.AddWithValue("@CategoryName", categoryName);
                    return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                }
            }
        }

        public void Create(Category category)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand addCommand = new SqlCommand("INSERT INTO Categories(CategoryName, Description) VALUES(@CategoryName, @Description)", connection))
                {
                    addCommand.Parameters.AddWithValue("@CategoryName", category.CategoryName);
                    addCommand.Parameters.AddWithValue("@Description", category.Description);                   
                    addCommand.ExecuteNonQuery();
                }
            }
        }

        public void Update(Category category)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand addCommand = new SqlCommand("UPDATE Categories SET CategoryName=@CategoryName, Description=@Description WHERE CategoryID=@CategoryID", connection))
                {
                    addCommand.Parameters.AddWithValue("@CategoryName", category.CategoryName);
                    addCommand.Parameters.AddWithValue("@Description", category.Description);
                    addCommand.Parameters.AddWithValue("@CategoryID", category.CategoryID);
                    addCommand.ExecuteNonQuery();
                }
            }
        }

        public void Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM [Products] WHERE CategoryID=@CategoryID", connection);
                cmd.Parameters.AddWithValue("@CategoryID", id);
                cmd.ExecuteNonQuery();

                cmd.CommandText = "DELETE FROM Categories WHERE CategoryID=@CategoryID";
                cmd.ExecuteNonQuery();
            }
        }
    }
}

