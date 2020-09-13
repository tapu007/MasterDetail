using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MasterDetailsApp.Models
{
    public class Purchase
    {
        [Key]
        public long PurchaseId { get; set; }
        public long CustomerId { get; set; }
        public Customer Customer { get; set; }
        public string ContactNo { get; set; }
        public DateTime PurchaseDate { get; set; } = DateTime.Now;

        public virtual ICollection<PurchaseDetails> PurchaseDetails { get; set; }

    }
}