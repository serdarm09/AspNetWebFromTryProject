using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace TryProject.Validations
{
    public class Validation
    {
        public bool IsUserExists(string userName, string email)
        {   
            bool userExists = false;
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=TryData;Integrated Security=True;";
            string query = "SELECT COUNT(*) FROM Users WHERE UserName = @UserName OR UserMail = @UserMail";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserName", userName);
                command.Parameters.AddWithValue("@UserMail", email);
                connection.Open();
                
                int count = (int)command.ExecuteScalar();

                if (count > 0)
                {
                    userExists = true;
                }
            }

            return userExists;
        }
    }
}