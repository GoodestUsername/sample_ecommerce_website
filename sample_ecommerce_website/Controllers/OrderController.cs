using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hangfire;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using Microsoft.Extensions.Configuration;
using sample_ecommerce_website.Models;
using sample_ecommerce_website.Models.DAL;
using Stripe;
using Stripe.Checkout;

namespace sample_ecommerce_website.Controllers
{
    [Authorize]
    public class OrderController : Controller
    {
        private readonly ProductDBModel _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IConfiguration _configuration;

        public string SessionId { get; set; }

        public class AddressViewModel
        {
            public UserAddress HomeAddress { get; set; }

            public UserAddress BillingAddress { get; set; }

            public UserAddress ShippingAddress { get; set; }
        }

        public OrderController(UserManager<ApplicationUser> userManager,
            ProductDBModel context, IConfiguration configuration)
        {
            _userManager = userManager;
            _context = context;
            _configuration = configuration;
            var stripe_secret = configuration["STRIPE_KEY"];
            Console.WriteLine("secret", stripe_secret);
        }

        public async Task<IActionResult> CheckoutView()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            return View(user.ShoppingCart);
        }

        public async Task<IActionResult> GoToAddressConfirmation()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            AddressViewModel ViewModel = new AddressViewModel
            {
                HomeAddress = user.HomeAddress,
                BillingAddress = user.BillingAddress,
                ShippingAddress = user.ShippingAddress
            };
         
            return View("AddressConfirmation", ViewModel);
        }

        public IActionResult CreateOrder(string amount)
        {
            var currency = "cad"; // Currency code
            var successUrl = "https://localhost:44371/Order/Success";
            var cancelUrl = "https://localhost:44371/Order/Cancel";
            StripeConfiguration.ApiKey = _configuration["STRIPE_KEY"];

            var options = new SessionCreateOptions
            {
                PaymentMethodTypes = new List<string>
                {
                    "card"
                },
                LineItems = new List<SessionLineItemOptions>
                {
                    new SessionLineItemOptions
                    {
                        PriceData = new SessionLineItemPriceDataOptions
                        {
                            Currency = currency,
                            UnitAmount = Convert.ToInt32(amount) * 100,  // Amount in smallest currency unit (e.g., cents)
                            ProductData = new SessionLineItemPriceDataProductDataOptions
                            {
                                Name = "TEST12345",
                                Description = "Product Description"
                            }
                        },
                        Quantity = 1
                    }
                },
                Mode = "payment",
                SuccessUrl = successUrl,
                CancelUrl = cancelUrl
            };

            var service = new SessionService();
            var session = service.Create(options);
            SessionId = session.Id;

            return Redirect(session.Url);
        }

        public IActionResult Success()
        {

            return View("SuccessView");
        }

        public IActionResult Cancel()
        {
            return RedirectToAction("index", "ShoppingCart");
        }
    }
}
