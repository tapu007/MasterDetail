using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MasterDetailsApp.Models
{
    public class Customer
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string ContactNo { get; set; }

        public ICollection<Purchase> Purchases { get; set; }

    }
}