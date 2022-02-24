using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
/// <summary>
/// ApplicationUser class
/// </summary>
namespace sample_ecommerce_website.Models
{
    public class ApplicationUser: IdentityUser
    {
        [PersonalData]
        [StringLength(200)]
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "First Name is required")]
        public virtual string FirstName { get; set; }

        [PersonalData]
        [StringLength(200)]
        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Last Name is required")]
        public virtual string LastName { get; set; }

        [PersonalData]
        [DisplayName("Email Address")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Email is required")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}",
            ErrorMessage = "Provided Email is is not valid.")]
        public override string Email { get; set; }

        [PersonalData]
        [StringLength(24)]
        [Display(Name = "Phone Number")]
        public virtual int PhoneNum { get; set; }

        // Account created date
        [PersonalData]
        [Display(Name = "Account Creation Date")]
        public DateTime CreationDate { get; set; }

        [PersonalData]
        [Display(Name = "Home Address")]
        public virtual UserAddress HomeAddress { get; set; }

        [PersonalData]
        [Display(Name = "Shipping Address")]
        public virtual UserAddress ShippingAddress { get; set; }

        [PersonalData]
        [Display(Name = "Billing Address")]
        public virtual UserAddress BillingAddress { get; set; }

        public virtual ShoppingCart ShoppingCart { get; set; }

        // Users past orders
        public virtual ICollection<OrderDetails> Orders { get; set; }

        public ApplicationUser() => Id = Guid.NewGuid().ToString();
    }
}
