using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    [Table("WorkOrder")]
    public class WorkOrder
    {
        [Key]
        [Display(Name = "Order ID")]
        public int OrderID { get; set; }

        [Display(Name = "Customer ID")]
        public virtual int? CustID { get; set; }
        public virtual Customer Customer { get; set; }

        [Display(Name = "Customer Instructions")]
        public String CustInstructions { get; set; }

        [Display(Name = "Special Discount")]
        public bool SpecialDiscount { get; set; }

        [Display(Name = "Priority/Back-Ordered?")]
        public bool Priority { get; set; }

        [Display(Name = "Date Shipped")]
        public DateTime? ShipDate { get; set; }
    }
}