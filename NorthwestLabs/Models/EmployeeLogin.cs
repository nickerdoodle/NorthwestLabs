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
        [Display(Name = "Username")]
        public String EmpUserName { get; set; }

        [Display(Name = "Password")]
        public String EmpPassword { get; set; }

        [Display(Name = "Last Login")]
        public DateTime LastLogin { get; set; }

        [Display(Name = "Last Password Change")]
        public DateTime LastPasswordChange { get; set; }
    }
}