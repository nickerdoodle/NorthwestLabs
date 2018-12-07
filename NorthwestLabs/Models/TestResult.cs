using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    [Table("TestResult")]
    public class TestResult
    {
        [Key]
        [Display(Name = "Test Result ID")]
        public int TestResultID { get; set; }

        [Display(Name = "Test Instance ID")]
        public int TestInstanceID { get; set; }

        [Display(Name = "Test File Path")]
        public String TestFilePath { get; set; }

        [Display(Name = "Test File Type ID")]
        public int TestFileTypeID { get; set; }
    }
}