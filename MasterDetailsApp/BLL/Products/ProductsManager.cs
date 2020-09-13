using MasterDetailsApp.DAL.Products;
using MasterDetailsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MasterDetailsApp.BLL.Products
{
    public class ProductsManager
    {
        ProductsRepository productsRepository = new ProductsRepository();
        public bool Add(Product product)
        {
            return productsRepository.Add(product);
        }
    }
}