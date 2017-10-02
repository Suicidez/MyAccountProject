using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration.Conventions;
namespace MyAccount.Models
{
    public class MyAccountContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public MyAccountContext() : base("name=MyAccountContext")
        {
            Database.Connection.ConnectionString = "server=DESKTOP-7VDPRQN\\SQLEXPRESS;database=MyAccount;uid=sa;password=passw@rd";
            Database.Connection.Open();
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
        public  DbSet<MasterModels.mstUser> mstUser { get; set; }
      
    }
}
