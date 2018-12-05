using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    [Table("Invoice")]
    public class Invoice
    {
     [Key]
        public int InvoiceID { get; set; }

        public int OrderID { get; set; }

        public DateTime PaymentDueDate { get; set; }

        public DateTime EarlyPMTDate { get; set; }

        public float EarlyPMTDiscount { get; set; }

        public float Price { get; set; }

        public DateTime DateCharged { get; set; }

        public float? Advance { get; set; }

        public float BalanceDue { get; set; }
    }
}