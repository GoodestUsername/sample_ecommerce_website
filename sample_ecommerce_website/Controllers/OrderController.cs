﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using sample_ecommerce_website.Models;
using sample_ecommerce_website.Models.DAL;

namespace sample_ecommerce_website.Controllers
{
    [Authorize]
    public class OrderController : Controller
    {
        private readonly ProductDBModel _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IConfiguration _configuration;

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

        public async Task<IActionResult> CreateOrder()
        {
            
            return View();
        }
    }
}
