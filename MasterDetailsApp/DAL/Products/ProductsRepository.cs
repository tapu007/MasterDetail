using MasterDetailsApp.DatabaseContexts;
using MasterDetailsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MasterDetailsApp.DAL.Products
{
    public class ProductsRepository
    {
        MasterDetailsDbContext db = new MasterDetailsDbContext();
        public bool Add(Product product)
        {
            db.Products.Add(product);
            return db.SaveChanges() > 0;
                
        }
    }
}