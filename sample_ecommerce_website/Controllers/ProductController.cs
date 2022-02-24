using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using sample_ecommerce_website.Models;
using sample_ecommerce_website.Models.DAL;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace sample_ecommerce_website.Controllers
{
    public class ProductController : Controller
    {
        private ProductDBModel MyContext { get; set; }

        public ProductController(ProductDBModel context)
        {
            MyContext = context;
        }

        // GET: NavigationController
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        // GET: get product
        public async Task<IActionResult> ProductView(string itemId)
        {
            var item = await MyContext.Products.Include(product => product.Images).FirstOrDefaultAsync(product => product.ProductId == itemId);
            
            if (item == null)
            {
                return RedirectToAction(actionName:"Index", controllerName:"Home");
            }

            return View(item);
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
