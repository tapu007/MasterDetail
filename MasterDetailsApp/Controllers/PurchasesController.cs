using MasterDetailsApp.DatabaseContexts;
using MasterDetailsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MasterDetailsApp.Controllers
{
    public class PurchasesController : Controller
    {
        MasterDetailsDbContext db = new MasterDetailsDbContext();
        public ActionResult Create()
        {
            ViewBag.CustomerId =  db.Customers.ToList();
            ViewBag.Product = db.Products.ToList();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Purchase purchase)
        {
            if (ModelState.IsValid && purchase.PurchaseDetails !=null && purchase.PurchaseDetails.Count > 0 )
            {
                
                db.Purchases.Add(purchase);
                var isAdded = db.SaveChanges() > 0;
                if (isAdded)
                {
                    ViewBag.CustomerId = db.Customers.ToList();
                    ViewBag.Product = db.Products.ToList();
                    return View(purchase);
                }

            }


            ViewBag.CustomerId = db.Customers.ToList();
            ViewBag.Product = db.Products.ToList();
            return View();
        }

    }
}