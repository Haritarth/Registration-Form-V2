using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Employee
    {
        [Required]

        public string FirstName
        {
            get;
            set;
        }
        public string LastName
        {
            get;
            set;
        }
        public string MiddleName
        {
            get;
            set;
        }
        public string TelephoneNumber
        {
            get;
            set;
        }

        //[Required]
        [EmailAddress]
        [Display(Name = "EmailAddress")]
        public string EmailAddress 
        { 
            get; 
            set; 
        }

        public string IdentificationNumber
        {
            get;
            set;
        }
        public DateTime DateOfBirth
        {
            get;
            set;
        }
        public string StreetAddress
        {
            get;
            set;
        }
        public string SecondaryAddress
        {
            get;
            set;
        }
        public string City
        {
            get;
            set;
        }
        public string State
        {
            get;
            set;
        }
        public string Zip
        {
            get;
            set;
        }

    }
}