using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using TryProject.DataBase;
using System.Security.Cryptography;
using TryProject.Class;
using TryProject.Validations;

namespace TryProject
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string userName = UserName.Text;
            string email = UserMail.Text;
            string password = UserPassword.Text;
            DataBaseOpen.CheckConnection();

            Validation validation = new Validation();
            if (validation.IsUserExists(userName, email))
            {

                ErrorLabel.Text = "Bu kullanıcı adı veya e-posta adresi zaten kullanımda.";
            
            
            }
            else
            {
                // Şifreyi hashlee
                string hashedPassword = Ssh256Convertor.ComputeSha256Hash(password);

                // Veritabanına kayıt et
                SqlCommand commmandRegister = new SqlCommand("INSERT INTO Users (UserName, Password, UserMail) VALUES (@name, @password, @mail)", DataBaseOpen.connection);
                commmandRegister.Parameters.AddWithValue("@name", userName);
                commmandRegister.Parameters.AddWithValue("@mail", email);
                commmandRegister.Parameters.AddWithValue("@password", hashedPassword);

                commmandRegister.ExecuteNonQuery();

                //oturumu başalatan işlem önemli!!
                Session["Username"] = userName;

                Response.Redirect("Home.aspx");
            }
        }
    }
}