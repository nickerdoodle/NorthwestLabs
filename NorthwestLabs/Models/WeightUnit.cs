using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    [Table("WeightUnit")]
    public class WeightUnit
    {
        [Key]
        public int WeightUnitID { get; set; }

        public String WeightUnitDesc { get; set; }

        //public virtual ICollection<Compound> Compounds { get; set; }
    }
}