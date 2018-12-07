using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    [Table("AssayType")]
    public class AssayType
    {
        [Key]
        [Display(Name = "Assay Type ID")]
        public int AssayTypeID { get; set; }

        [Display(Name = "Assay Type")]
        public String TypeDescription { get; set; }
    }
}