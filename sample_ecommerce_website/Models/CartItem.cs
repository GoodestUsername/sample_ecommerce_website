using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

/// <summary>
/// Cart item class
/// </summary>
namespace sample_ecommerce_website.Models
{
    public class CartItem
    {
        [Required(ErrorMessage = "ID is required")]
        public string cart_item_id;

        public int quantity;

        // Foreign Key
        public virtual string ProductID { get; set; }

        [ForeignKey("ProductID")]
        public virtual Product Product { get; set; }

        // Foreign Key
        public virtual string CartID { get; set; }

        // Cart item is associated with.
        [ForeignKey("CardID")]
        public virtual ShoppingCart ShoppingCart { get; set; }
    }
}
