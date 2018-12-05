using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    [Table("Material")]
    public class Material
    {
        public int MaterialID { get; set; }

        public String MaterialType { get; set; }

        public int QuantityOnHand { get; set; }

        public int UnitID { get; set; }

        public int CostID { get; set; }
    }
}