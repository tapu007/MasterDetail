using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MasterDetailsApp.Models
{
    public class Product
    {
        [Key]
        public long ProductId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        



    }
}