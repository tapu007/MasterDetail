using MasterDetailsApp.BLL.Products;
using MasterDetailsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MasterDetailsApp.Controllers
{
    public class ProductsController : Controller
    {
        ProductsManager productsManager = new ProductsManager();
        // GET: Products
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                if (productsManager.Add(product))
                {
                    ViewBag.Message = "Saved Successful";
                }
                else
                {
                    ViewBag.Message = "Saved Failled";
                }
            }
            return View(product);
        }

    }
}