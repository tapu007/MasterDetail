using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;

namespace MasterDetailsApp.Models
{
    public class PurchaseDetails
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int Qty { get; set; }
        public double Price { get; set; }
        public int TotalAmount { get; set; }
        public long PurchaseId { get; set; }
        public virtual Purchase Purchase { get; set; }




    }
}