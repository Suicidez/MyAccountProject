using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Net;
using System.Web.Mvc;
namespace MyAccount.Models
{
    
    public class MainModels : Controller
    {
        public MyAccountContext MyContext = new MyAccountContext();

        private DbSet<MasterModels.mstUser> _mstUser;

   
        public void OpenConnnection()
        {
            try
                {
                    if (MyContext.Database.Connection.State != System.Data.ConnectionState.Open)
                    {
                        MyContext.Database.Connection.Open();
                    }
                        
                }
                catch(Exception ex)
                {
             
                }
    
            
        }
        public void CloseConnection()
        {
            try
                {
                    if (MyContext.Database.Connection.State != System.Data.ConnectionState.Closed)
                    {
                        MyContext.Database.Connection.Close ();
                    }

                }
                catch (Exception ex)
                {
                
                }
    
        }
        public  DbSet<MasterModels.mstUser> mstUser()
        {

            OpenConnnection();
  
            _mstUser = MyContext.mstUser;                                    
                return _mstUser;
            
        }
    }
}