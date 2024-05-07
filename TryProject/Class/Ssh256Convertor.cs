using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
//database Güvenliği için hashleme işlemi yaptık
namespace TryProject.Class
{
    public class Ssh256Convertor
    {
        public static string ComputeSha256Hash(string rawData)
        {
            // SHA256 OLUŞTURDUK
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // Hashleme
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));


                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}