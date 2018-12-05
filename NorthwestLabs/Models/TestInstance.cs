using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    [Table("TestInstance")]
    public class TestInstance
    {
        [Key]
        public int TestInstanceID { get; set; }

        public int TestTypeID { get; set; }

        public int AssayID { get; set; }

        public int SequenceID { get; set; }

        public bool Required { get; set; }

        public bool Approved { get; set; }

        public DateTime DateCompleted { get; set; }

        public Double BasePrice { get; set; }

        public DateTime DateScheduled { get; set; }

        public bool Rerun { get; set; }

        public String RerunComments { get; set; }

        public bool Success { get; set; }
    }
}