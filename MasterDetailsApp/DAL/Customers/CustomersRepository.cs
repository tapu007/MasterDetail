using MasterDetailsApp.DatabaseContexts;
using MasterDetailsApp.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace MasterDetailsApp.DAL.Customers
{
    public class CustomersRepository
    {

        MasterDetailsDbContext db = new MasterDetailsDbContext();
        
        public bool Save(Customer customer)
        {
            db.Customers.Add(customer);
            return db.SaveChanges() > 0;
        }

    }
}