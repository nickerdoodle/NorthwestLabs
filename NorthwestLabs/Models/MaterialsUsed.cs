using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    [Table("MaterialsUsed")]
    public class MaterialsUsed
    {
        [Key]
        public int MaterialID { get; set; }

        [Key]
        public int TestInstanceID { get; set; }

        public float AmountConsumed { get; set; }

        public int UnitID { get; set; }
    }
}