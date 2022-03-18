using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using sample_ecommerce_website.Models;
using sample_ecommerce_website.Models.DAL;

namespace sample_ecommerce_website.Controllers
{
    [Authorize]
    public class ShoppingCartController : Controller
    {
        private readonly ProductDBModel _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public 
        public ShoppingCartController(UserManager<ApplicationUser> userManager, 
            ProductDBModel context)
        {
            _userManager = userManager;

            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            return View(user.ShoppingCart.CartItems.ToList());
        }

        public async Task<IActionResult> AddToCart(string itemId)
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }
            List<CartItem> cart = user.ShoppingCart.CartItems.ToList();

            int index = cart.FindIndex(item => item.ProductId == itemId);
           
            if (index == -1)
            {
                CartItem newCartItem = new()
                {
                    ProductId = itemId,
                    Quantity = 1,
                    DateCreated = DateTime.Now
                };
                user.ShoppingCart.CartItems.Add(newCartItem);
            }
            else
            {
                cart[index].Quantity += 1;
                user.ShoppingCart.CartItems = cart;
            }
            user.ShoppingCart.ItemQuantity += 1;
            user.ShoppingCart.Total += _context.Products.Find(itemId).Price;
            await _userManager.UpdateAsync(user);

            return View("Index", user.ShoppingCart.CartItems.ToList());
        }

        public async Task<IActionResult> RemoveOneFromCart(string itemId)
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }
            List<CartItem> cart = user.ShoppingCart.CartItems.ToList();

            int index = cart.FindIndex(item => item.ProductId == itemId);

            cart[index].Quantity -= 1;
            if (cart[index].Quantity == 0)
            {
                cart.RemoveAt(index);
            }
            user.ShoppingCart.CartItems = cart;

            user.ShoppingCart.ItemQuantity -= 1;
            user.ShoppingCart.Total -= _context.Products.Find(itemId).Price;
            await _userManager.UpdateAsync(user);

            return View("Index", user.ShoppingCart.CartItems.ToList());
        }

        public async Task<IActionResult> RemoveFromCart(string itemId)
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }
            List<CartItem> cart = user.ShoppingCart.CartItems.ToList();

            int index = cart.FindIndex(item => item.ProductId == itemId);
            int quantity = cart[index].Quantity;
            cart.RemoveAt(index);
            user.ShoppingCart.CartItems = cart;

            user.ShoppingCart.ItemQuantity -= quantity;
            user.ShoppingCart.Total -= _context.Products.Find(itemId).Price * quantity;
            await _userManager.UpdateAsync(user);

            return View("Index", user.ShoppingCart.CartItems.ToList());
        }

        public async Task<IActionResult> EmptyFromCart()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }
            List<CartItem> cart = new();

            user.ShoppingCart.CartItems = cart;
            user.ShoppingCart.ItemQuantity = 0;
            user.ShoppingCart.Total = 0;
            await _userManager.UpdateAsync(user);

            return View("Index", user.ShoppingCart.CartItems.ToList());
        }
    }
}
