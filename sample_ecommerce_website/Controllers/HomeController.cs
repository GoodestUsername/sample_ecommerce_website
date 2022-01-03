using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using sample_ecommerce_website.Models;
using sample_ecommerce_website.Models.DAL;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace sample_ecommerce_website.Controllers
{
    public class HomeController : Controller
    {
        // private readonly ILogger<HomeController> _logger;
        /*        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }*/
        private ProductDBContext MyContext { get; set; }

        public HomeController(ProductDBContext context)
        {
            MyContext = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ProductsView()
        {
            MyContext.Products.Include(product => product.Images).ToList();
            var products = from p in MyContext.Products select p;

            return View(products.ToList());
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
