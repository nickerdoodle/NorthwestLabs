using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    [Table("Material")]
    public class Material
    {
        [Key]
        [Display(Name = "Material ID")]
        public int MaterialID { get; set; }

        [Display(Name = "Material")]
        public String MaterialDesc { get; set; }

        [Display(Name = "Quantity on Hand")]
        public Double QuantityOnHand { get; set; }

        [Display(Name = "Unit ID")]
        public virtual int WeightUnitID { get; set; }
        public virtual WeightUnit WeightUnit { get; set; }

        [Display(Name = "Cost ID")]
        public virtual int CostID { get; set; }
       


    }
}