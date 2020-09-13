using MasterDetailsApp.DAL.Customers;
using MasterDetailsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MasterDetailsApp.BLL.Customers
{
    public class CustomersManager
    {
        CustomersRepository customersRepository = new CustomersRepository();
        public bool Add(Customer customer)
        {
            return customersRepository.Save(customer);
        }
    }
}