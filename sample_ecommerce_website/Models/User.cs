using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
/// <summary>
/// User class
/// </summary>
namespace sample_ecommerce_website.Models
{
    public class User: IdentityUser<Guid>
    {
        [PersonalData]
        [StringLength(200)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [PersonalData]
        [StringLength(200)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [PersonalData]
        [Display(Name = "Home Address")]
        public virtual UserAddress HomeAddress { get; set; }

        [PersonalData]
        [Display(Name = "Shipping Address")]
        public virtual UserAddress ShippingAddress { get; set; }

        [PersonalData]
        [Display(Name = "Billing Address")]
        public virtual UserAddress BillingAddress { get; set; }

        [PersonalData]
        [Display(Name = "Phone Number")]
        public int PhoneNum { get; set; }

        // Account created date
        [PersonalData]
        [Display(Name = "Account Creation Date")]
        public DateTime CreationDate { get; set; }

        public User()
        {
            Id = Guid.NewGuid();
        }
    }
}
