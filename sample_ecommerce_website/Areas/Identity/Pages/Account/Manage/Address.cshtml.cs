using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using sample_ecommerce_website.Models;
using sample_ecommerce_website.Models.DAL;

namespace sample_ecommerce_website.Areas.Identity.Pages.Account.Manage
{
    public class AddressModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;

        private ProductDBModel _context { get; set; }

        public AddressModel(
            UserManager<ApplicationUser> userManager,
            ProductDBModel MyContext
            )
        {
            _userManager = userManager;
            _context = MyContext;
        }


        [TempData]
        public string StatusMessage { get; set; }

        public static UserAddress HomeAddress { get; set; }
        public static UserAddress BillingAddress { get; set; }
        public static UserAddress ShippingAddress { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            _context.Entry(user).Reference(u => u.HomeAddress).Load();
            _context.Entry(user).Reference(u => u.BillingAddress).Load();
            _context.Entry(user).Reference(u => u.ShippingAddress).Load();
            HomeAddress = user.HomeAddress;
            BillingAddress = user.BillingAddress;
            ShippingAddress = user.ShippingAddress;
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(AddressTypes type)
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


            return RedirectToPage("./AddAddress", type);
        }
    }
}
