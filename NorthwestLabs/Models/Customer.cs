using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestLabs.Models
{
    [Table("Customer")]
    public class Customer
    {
        [Key]
        public int CustID { get; set; }

        public String CustFirstName { get; set; }


        public String CustLastName { get; set; }

        public String CustAddress1 { get; set; }

        public String CustAddress2 { get; set; }

        public String CustCity { get; set; }

        public int StateID { get; set; }

        public String Zip { get; set; }

        public int CountryID { get; set; }

        public String Phone { get; set; }

        public String Email { get; set; }

        public String PaymentInfo { get; set; }

        public String CustUserName { get; set; }

        public String Comments { get; set; }

        public float Balance { get; set; }
    }
}