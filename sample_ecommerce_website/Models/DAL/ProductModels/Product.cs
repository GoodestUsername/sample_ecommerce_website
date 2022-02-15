using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string ProductId { get; set; }

        // Product name
        [StringLength(255)]
        [Display(Name = "Name")]
        [Required(ErrorMessage = "Product name is required")]
        public string Name { get; set; }

        // Product price
        [StringLength(255)]
        [Display(Name = "Price")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public double Price { get; set; }

        // Product Category
        [StringLength(255)]
        [Display(Name = "Category")]
        [Required(ErrorMessage = "Product category is required")]
        public string Category { get; set; }

        // Product Description
        [StringLength(255)]
        [Display(Name = "Description")]
        public string Description { get; set; }

        // Product Stock (quantity)
        [Required(ErrorMessage = "Product stock avalible is required")]
        public int Stock { get; set; }

        // Product images
        public virtual ICollection<Image> Images { get; set; }

        public string DiscountId { get; set; }
    }
}
