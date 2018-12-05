using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    [Table("TestDetail")]
    public class TestDetail
    {
        [Key]
        public int TestInstanceID { get; set; }

        [Key]
        public int EmpID { get; set; }

        public float EmpHours { get; set; }
    }
}