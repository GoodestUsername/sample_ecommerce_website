using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sample_ecommerce_website.Models.ViewModels.ShoppingCartViewModel
{
    public class CartViewModel
    {
        public List<ShoppingCart> ShoppingCart { get; set; }
        public decimal CartTotal { get; set; }
    }
}
