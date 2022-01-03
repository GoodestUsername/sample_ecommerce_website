using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
/// <summary>
/// Product Class
/// </summary>
namespace sample_ecommerce_website.Models
{
    public class Product
    {
        // Product ID
        [Required(ErrorMessage = "ID is required")]
        public string ProductID { get; set; }

        // Product name
        [Required(ErrorMessage = "Product name is required")]
        public string Name { get; set; }

        // Product price
        [Required(ErrorMessage = "Product price is required")]
        public double Price { get; set; }

        // Product Category
        [Required(ErrorMessage = "Product category is required")]
        public string Category { get; set; }

        // Product Description
        [Required(ErrorMessage = "Product description is required")]
        public string Description { get; set; }

        // Product Stock (quantity)
        [Required(ErrorMessage = "Product stock avalible is required")]
        public int Stock { get; set; }
        // Product images
        public virtual ICollection<Image> Images { get; set; }

        public string DiscountID { get; set; }
    }
}
