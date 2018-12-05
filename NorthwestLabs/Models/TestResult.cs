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
        public int TestResultID { get; set; }

        public int TestInstanceID { get; set; }

        public String TestFilePath { get; set; }

        public int TestFileTypeID { get; set; }
    }
}