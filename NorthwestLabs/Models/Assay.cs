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
        public int AssayID { get; set; }

        public String Description { get; set; }

        public String Protocol { get; set; }

        public int? DaysToComplete { get; set; }

        public DateTime? TimeReceived { get; set; }

        public int AssayTypeID { get; set; }
    }
}