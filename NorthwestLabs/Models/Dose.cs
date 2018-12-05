using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    [Table("Dose")]
    public class Dose
    {
        [Key]
        public int DoseID { get; set; }

        public Double MTD { get; set; }

        public int UnitID { get; set; }
    }
}