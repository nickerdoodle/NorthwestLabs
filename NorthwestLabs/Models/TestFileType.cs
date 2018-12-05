using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    [Table("TestFileType")]
    public class TestFileType
    {
        [Key]
        public int TestFileTypeID { get; set; }

        public String TestFileTypeDesc { get; set; }
    }
}