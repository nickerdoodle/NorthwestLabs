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
        public int AssayTypeID { get; set; }

        public String TypeDescription { get; set; }
    }
}