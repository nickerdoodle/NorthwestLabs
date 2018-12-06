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

        public Double EarlyPMTDiscount { get; set; }

        public Double Price { get; set; }

        public DateTime DateCharged { get; set; }

        public Double? Advance { get; set; }

        public Double BalanceDue { get; set; }
    }
}