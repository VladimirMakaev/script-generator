using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VisaApplicationForm.Models
{
    public class Address
    {
        public string Country
        {
            get; set;
        }

        public string State
        {
            get; set;
        }

        public string City
        {
            get; set;
        }

        public string AddressLine1
        {
            get; set;
        }

        public string PostalCode
        {
            get; set;
        }

        public string PhonePrefix
        {
            get; set;
        }

        public string PhoneNumber
        {
            get; set;
        }

        public string Email
        {
            get; set;
        }
    }
}