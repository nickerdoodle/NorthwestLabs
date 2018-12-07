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
        [Display(Name = "Weight Unit ID")]
        public int WeightUnitID { get; set; }

        [Display(Name = "Weight Unit")]
        public String WeightUnitDesc { get; set; }

        //public virtual ICollection<Compound> Compounds { get; set; }
    }
}