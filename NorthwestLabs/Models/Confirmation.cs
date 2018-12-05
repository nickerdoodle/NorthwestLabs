using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    [Table("Confirmation")]
    public class Confirmation
    {
        [Key]
        public int ConfID { get; set; }

        public DateTime DateTime { get; set; }
    }
}