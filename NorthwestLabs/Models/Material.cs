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
        public int MaterialID { get; set; }

        public String MaterialDesc { get; set; }

        public Double QuantityOnHand { get; set; }

        public virtual int WeightUnitID { get; set; }
        public virtual WeightUnit WeightUnit { get; set; }

        public virtual int CostID { get; set; }
       


    }
}