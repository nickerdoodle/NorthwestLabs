using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using NorthwestLabs.Models;

namespace NorthwestLabs.Models
{
    [Table("UnitOfMeasure")]
    public class UnitOfMeasure
    {
        [Key]
        public int UnitID { get; set; }

        public String UnitDesc { get; set; }

        //public virtual ICollection<Compound> Compounds { get; set; }
    }
}