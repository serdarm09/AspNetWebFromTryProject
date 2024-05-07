using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace TryProject
{
    public partial class Home : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Username"] != null)
            {
                // Kullanıcı giriş yapmış, özel içeriği göster
                WelcomeMessage.Text = "Hoş geldiniz, " + Session["Username"].ToString() + "!";
                // Örneğin, giriş yapmış kullanıcıya özel bir mesaj veya içerik gösterebilirsiniz.
            }
            else
            {
                // Kullanıcı giriş yapmamış, genel içeriği göster
                WelcomeMessage.Text = "Hoş geldiniz!";
                LoginButton.Visible = true; // Butonu görünür yap
            }
        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            // Kullanıcıyı login sayfasına yönlendir
            Response.Redirect("Login.aspx");
        }
    }
}
