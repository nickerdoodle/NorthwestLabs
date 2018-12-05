using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    [Table("LiteratureReferences")]
    public class LiteratureReferences
    {
        [Key]
        public int ReferenceID { get; set; }

        public String ReferenceDesc { get; set; }

        public int AssayID { get; set; }
    }
}