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
        public int CompSequenceCode { get; set; }

        [Key]
        public int LTNumber { get; set; }

        public float Volume { get; set; }

        public int VolumeUnitID { get; set; }

        public float Weight { get; set; }

        public int WeightUnitID { get; set; }

        public String Appearance { get; set; }

        public int AssayID { get; set; }

        public float Concentration { get; set; }
    }
}