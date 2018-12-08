using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    [Table("CompoundSample")]
    public class CompoundSample
    {
        [Key]
        [Display(Name = "Compount Sequence Code")]
        public int CompSequenceCode { get; set; }

        [Key]
        [Display(Name = "LT Number")]
        public int LTNumber { get; set; }

        [Display(Name = "Volume")]
        public Double Volume { get; set; }

        [Display(Name = "Volume Unit ID")]
        public int VolumeUnitID { get; set; }

        [Display(Name = "Weight")]
        public Double Weight { get; set; }

        [Display(Name = "Weight Unit ID")]
        public int WeightUnitID { get; set; }

        [Display(Name = "Appearance")]
        public String Appearance { get; set; }

        [Display(Name = "Assay ID")]
        public int AssayID { get; set; }

        [Display(Name = "Concentration")]
        public Double Concentration { get; set; }
    }
}