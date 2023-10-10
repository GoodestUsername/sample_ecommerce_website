using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

/// <summary>
/// Address class for storing user addresses
/// </summary>
namespace sample_ecommerce_website.Models
{
    public enum AddressTypes
    {
        HomeAddress,
        BillingAddress,
        ShippingAddress
    }
    public class UserAddress
    {
        // Address Details ID
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual string AddressId { get; set; }

        [PersonalData]
        [StringLength(200)]
        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Full name is required")]
        public virtual string Name { get; set; }

        [PersonalData]
        [StringLength(200)]
        [Display(Name = "Address")]
        [Required(ErrorMessage = "Street Address is required")]
        public virtual string AddressLine1 { get; set; }

        [PersonalData]
        [StringLength(200)]
        [Display(Name = "Address 2")]
        public virtual string AddressLine2 { get; set; }

        [PersonalData]
        [StringLength(100)]
        [Display(Name = "City")]
        [Required(ErrorMessage = "City is required")]
        public virtual string City { get; set; }

        [PersonalData]
        [StringLength(60)]
        [Display(Name = "Province")]
        [Required(ErrorMessage = "Province is required")]
        public virtual string Province { get; set; }

        [PersonalData]
        [StringLength(10)]
        [Display(Name = "Postal code")]
        [Required(ErrorMessage = "Postal code is required")]
        public virtual string PostalCode { get; set; }

        [PersonalData]
        [StringLength(60)]
        [Display(Name = "Country")]
        [Required(ErrorMessage = "Country is required")]
        public virtual string Country { get; set; }

        public bool IsAllMandatoryFieldsNull()
        {
            return this.Name == null && this.AddressLine1 == null &&
                this.City == null && this.Province == null && this.PostalCode == null &&
                this.Country == null;
        }

        public bool IsAnyMandatoryFieldsNull()
        {
            return this.Name == null || this.AddressLine1 == null ||
                this.City == null || this.Province == null || this.PostalCode == null ||
                this.Country == null;
        }
    }
}
