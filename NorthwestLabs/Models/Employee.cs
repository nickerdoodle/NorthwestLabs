using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    [Table("Employee")]
    public class Employee
    {
        [Key]
        [Display(Name = "Employee ID")]
        public int EmpID { get; set; }

        public String EmpUserName { get; set; }

        public String EmpFirstName { get; set; }

        public String EmpLastName { get; set; }

        public String EmpAddress1 { get; set; }

        public String EmpAddress2 { get; set; }

        public String EmpCity { get; set; }

        public int EmpStateID { get; set; }

        public int EmpCountryID { get; set; }

        public String EmpPhone { get; set; }

        public String EmpEmail { get; set; }

    }
}