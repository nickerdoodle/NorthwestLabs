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
        public int CostID { get; set; }

        public float CostPerUnit { get; set; }

        public DateTime DatePurchased { get; set; }

        public String UnitID { get; set; }
    }
}