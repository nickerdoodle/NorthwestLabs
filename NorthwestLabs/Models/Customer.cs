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
        [Display(Name = "Customer ID")]
        public int CustID { get; set; }

        [Display(Name = "First Name")]
        public String CustFirstName { get; set; }

        [Display(Name = "Last Name")]
        public String CustLastName { get; set; }

        [Display(Name = "Address 1")]
        public String CustAddress1 { get; set; }

        [Display(Name = "Address 2")]
        public String CustAddress2 { get; set; }

        [Display(Name = "City")]
        public String CustCity { get; set; }

        [Display(Name = "State ID")]
        public virtual int? StateID { get; set; }
        public virtual State state { get; set; }

        [Display(Name = "ZIP")]
        public String CustZip { get; set; }

        [Display(Name = "Country ID")]
        public int CountryID { get; set; }
        public virtual Country country { get; set; }

        [Display(Name = "Phone")]
        public String CustPhone { get; set; }

        [EmailAddress]
        [Display(Name ="Email")]
        public String CustEmail { get; set; }

        [Display(Name = "Bank Name")]
        public String PaymentInfo { get; set; }

        [Display(Name = "Username")]
        public String CustUserName { get; set; }
        public virtual CustomerLogin customerLogin { get; set; }

        [Display(Name = "Customer Comments")]
        public String Comments { get; set; }

        [Display(Name = "Customer Balance")]
        public Decimal Balance { get; set; }

        //public virtual ICollection<WorkOrder> WorkOrders { get; set; }
    }
}