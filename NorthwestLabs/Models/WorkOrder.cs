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
        public int OrderID { get; set; }

        public int CustID { get; set; }

        public String CustInstructions { get; set; }

        public bool SpecialDiscount { get; set; }

        public bool Priority { get; set; }

        public DateTime? ShipDate { get; set; }
    }
}