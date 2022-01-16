using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [StringLength(100)]
        [Display(Name = "Address")]
        [Required(ErrorMessage = "Street Address is required")]
        public string AddressLine1 { get; set; }

        [PersonalData]
        [StringLength(100)]
        [Display(Name = "Address 2")]
        public string AddressLine2 { get; set; }

        [PersonalData]
        [StringLength(100)]
        [Display(Name = "City")]
        [Required(ErrorMessage = "City is required")]
        public string City { get; set; }

        [PersonalData]
        [StringLength(100)]
        [Display(Name = "State/Province")]
        [Required(ErrorMessage = "State is required")]
        public string StateEquivalent { get; set; }

        [PersonalData]
        [StringLength(100)]
        [Display(Name = "Postal code")]
        [Required(ErrorMessage = "Postal code is required")]
        public string PostalCode { get; set; }

        [PersonalData]
        [StringLength(100)]
        [Display(Name = "Country")]
        [Required(ErrorMessage = "Country is required")]
        public string Country { get; set; }

        [PersonalData]
        [StringLength(100)]
        [Display(Name = "Phone number")]
        public int HomePhone { get; set; }

        [PersonalData]
        [Display(Name = "Mobile phone number")]
        public int MobilePhone { get; set; }
    }
}
