using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using sample_ecommerce_website.Models;

namespace sample_ecommerce_website.Areas.Identity.Pages.Account
{
    public class AddAddressModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public AddAddressModel(
            UserManager<ApplicationUser> userManager
            )
        {
            _userManager = userManager;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        private AddressTypes AddressType;

        public class InputModel
        {
            [PersonalData]
            [StringLength(200)]
            [Display(Name = "Full name")]
            [Required(ErrorMessage = "Full name of is required")]
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
            [DataType(DataType.PostalCode)]
            [Required(ErrorMessage = "Postal code is required")]
            public virtual string PostalCode { get; set; }

            [PersonalData]
            [StringLength(60)]
            [Display(Name = "Country")]
            [Required(ErrorMessage = "Country is required")]
            public virtual string Country { get; set; }
        }

        public async Task<IActionResult> OnGetAsync(AddressTypes type)
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            AddressType = type;

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var user = await _userManager.GetUserAsync(User);

            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            if (ModelState.IsValid)
            {
                var address = new UserAddress {
                    Name = Input.Name,
                    AddressLine1 = Input.AddressLine1,
                    AddressLine2 = Input.AddressLine2,
                    Country = Input.Country,
                    Province = Input.Province,
                    City = Input.City,
                    PostalCode = Input.PostalCode
                };

                switch (AddressType)
                {
                    case AddressTypes.HomeAddress:
                        user.HomeAddress = address;
                        break;

                    case AddressTypes.BillingAddress:
                        user.BillingAddress = address;
                        break;

                    case AddressTypes.ShippingAddress:
                        user.ShippingAddress = address;
                        break;
                }


                await _userManager.UpdateAsync(user);
            }

            return RedirectToPage("./Address");
        }
    }
}
