using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    [Table("EmployeeLogin")]
    public class EmployeeLogin
    {
        [Key]
        public String EmpUserName { get; set; }

        public String EmpPassword { get; set; }

        public DateTime LastLogin { get; set; }

        public DateTime LastPasswordChange { get; set; }
    }
}