using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    [Table("Assay")]
    public class Assay
    {
        [Key]
        [Display(Name ="Assay ID")]
        public int AssayID { get; set; }

        [Display(Name = "Description")]
        public String Description { get; set; }

        [Display(Name = "Days To Complete")]
        public int? DaysToComplete { get; set; }

        [Display(Name = "Assay Type ID")]
        public int AssayTypeID { get; set; }
        public virtual AssayType assayType { get; set; }
    }
}