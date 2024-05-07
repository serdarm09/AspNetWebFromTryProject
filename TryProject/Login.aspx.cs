using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using TryProject.Class;

namespace TryProject
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Burada sayfa yüklendiğinde yapılacak işlemler tanımlanabilir.
            // Genellikle oturum kontrolü, sayfa başlığı ayarlama gibi işlemler yapılabilir.
        }
        protected void LoginButton_Click(object sender, EventArgs e)
        {
            string username = UsernameTextBox.Text;
            string password = PasswordTextBox.Text;

            // Şifreyi hashledim
            string hashedPassword = Ssh256Convertor.ComputeSha256Hash(password);

            // Kullanıcı adı ve hashlenmiş şiffreyi sorguladık
            bool loginSuccessful = ValidateUser(username, hashedPassword);

            if (loginSuccessful)
            {
                //session oluşturna hocanını istediği
                Session["Username"] = username;

                Response.Redirect("Home.aspx");
            }
            else
            {
                // Giriş başarısızsa, kullanıcıya hata mesajını göster
                ErrorMessageLabel.Text = "Hatalı kullanıcı adı veya şifre.";
            }
        }

      
        protected bool ValidateUser(string username, string hashedPassword)
        {
            bool isValid = false;

            // Veritabanına bağlan
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=TryData;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username AND Password = @Password";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", hashedPassword);

                connection.Open();
                int count = (int)command.ExecuteScalar();
                isValid = (count > 0);
            }

            return isValid;
        }

    }
}
