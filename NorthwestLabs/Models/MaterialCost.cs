using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    [Table("MaterialCost")]
    public class MaterialCost
    {
        [Key]
        [Display(Name = "Cost ID")]
        public int CostID { get; set; }

        [Display(Name = "Cost per Unit")]
        public Double CostPerUnit { get; set; }

        [Display(Name = "Date Purchased")]
        public DateTime DatePurchased { get; set; }

        [Display(Name = "Unit ID")]
        public String UnitID { get; set; }
    }
}