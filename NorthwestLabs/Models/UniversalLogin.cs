using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    public class UniversalLogin
    {

        public String Username { get; set; }

        [DataType(DataType.Password)]
        public String Password { get; set; }

        public bool RememberMe { get; set; }
    }
}