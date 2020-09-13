using MasterDetailsApp.BLL.Customers;
using MasterDetailsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MasterDetailsApp.Controllers
{
    public class CustomersController : Controller
    {
        CustomersManager customersManager = new CustomersManager();
        // GET: Customers
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            if (ModelState.IsValid)
            {
                if (customersManager.Add(customer))
                {
                    ViewBag.Message = "Saved Successful";
                }
                else
                {
                    ViewBag.Message = "Save Failled";
                }
                
            }
            return View(customer);
        }
    }
}