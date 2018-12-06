using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    [Table("VolumeUnit")]
    public class VolumeUnit
    {
        [Key]
        public int VolumeUnitID { get; set; }

        public String VolumeUnitDesc { get; set; }

        //public virtual ICollection<Compound> Compounds { get; set; }
    }
}