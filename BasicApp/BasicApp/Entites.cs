using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace BasicApp
{
    public class MyContext : DbContext
    {
        public DbSet<Blogs1> Entites { get; set; }
    }

    public class Entites
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        public string Surname { get; set; }
        public string Password {  get; set; }    
        public bool IsActive { get; set; }
    }
}