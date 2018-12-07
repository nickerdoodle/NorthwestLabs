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
        [Display(Name = "Invoice ID")]
        public int InvoiceID { get; set; }

        [Display(Name = "Order ID")]
        public int OrderID { get; set; }

        [Display(Name = "Payment Due")]
        public DateTime PaymentDueDate { get; set; }

        [Display(Name = "Early Payment Date")]
        public DateTime EarlyPMTDate { get; set; }

        [Display(Name = "Early Discount")]
        public Double EarlyPMTDiscount { get; set; }

        [Display(Name = "Price")]
        public Double Price { get; set; }

        [Display(Name = "Date Charged")]
        public DateTime DateCharged { get; set; }

        [Display(Name = "Advance Payment")]
        public Double? Advance { get; set; }

        [Display(Name = "Balance Due")]
        public Double BalanceDue { get; set; }
    }
}