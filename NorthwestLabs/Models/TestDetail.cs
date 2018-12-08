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
        [Display(Name = "Test Instance ID")]
        public int TestInstanceID { get; set; }

        [Key]
        [Display(Name = "Employee ID")]
        public int EmpID { get; set; }

        [Display(Name = "Hours Worked")]
        public Double EmpHours { get; set; }
    }
}