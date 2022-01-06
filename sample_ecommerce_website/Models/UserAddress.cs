using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/// <summary>
/// Address class for storing user addresses
/// </summary>
namespace sample_ecommerce_website.Models
{
    public class UserAddress
    {
        [PersonalData]
        public string AddressLine1 { get; set; }

        [PersonalData]
        public string AddressLine2 { get; set; }

        [PersonalData]
        public string City { get; set; }

        [PersonalData]
        public string StateEquivalent { get; set; }

        [PersonalData]
        public string PostalCode { get; set; }

        [PersonalData]
        public string country { get; set; }

        [PersonalData]
        public int HomePhone { get; set; }

        [PersonalData]
        public int MobilePhone { get; set; }
    }
}
