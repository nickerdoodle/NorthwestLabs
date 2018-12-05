using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    [Table("Position")]
    public class EmployeeType
    {
        [Key]
        public int PositionID { get; set; }

        public String PositionDesc { get; set; }

        public int AccessID { get; set; }
    }
}