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
        [Display(Name = "Max Tolerated Dose ID")]
        public int DoseID { get; set; }
        [Display(Name = "Max Tolerated Dose")]
        public Double MTD { get; set; }

        [Display(Name = "Dose Unit ID")]
        public int UnitID { get; set; }
    }
}