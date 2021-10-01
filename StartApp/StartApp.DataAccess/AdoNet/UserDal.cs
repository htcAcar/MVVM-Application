using System;
using System.Data.SqlClient;
using StartApp.Entities.Concrete;

namespace StartApp.DataAccess.AdoNet
{
    public class UserDal
    {
        private string _connectionString;
        public UserDal(string connectionString)
        {
            _connectionString = connectionString;
        }

        public int Create(User user)
        {
            int result = 0;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand addCommand = new SqlCommand("INSERT INTO Users(Name, Password, Mail, Phone, Birthday, City, Gender, Contact) VALUES(@Name,@Password,@Mail,@Phone,@Birthday,@City,@Gender,@Contact) ", connection))
                {
                    addCommand.Parameters.AddWithValue("@Name", user.Name);
                    addCommand.Parameters.AddWithValue("@Password", user.Password);
                    addCommand.Parameters.AddWithValue("@Mail", user.Mail);
                    addCommand.Parameters.AddWithValue("@Phone", user.Phone);
                    addCommand.Parameters.AddWithValue("@Birthday", user.Birthday);
                    addCommand.Parameters.AddWithValue("@City", user.City);
                    addCommand.Parameters.AddWithValue("@Gender", (int)user.Gender);
                    addCommand.Parameters.AddWithValue("@Contact", (int)user.Contact);                    
                    result = addCommand.ExecuteNonQuery();
                }
            }
            return result;
        }

        public bool ExistsUserInLoginPage(string name, string password)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) from Users where Name=@name AND Password=@password", connection);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@password", password);
                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }

        }
    }
}
