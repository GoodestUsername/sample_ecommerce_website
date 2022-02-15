using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

/// <summary>
/// Cart item class
/// </summary>
namespace sample_ecommerce_website.Models.DAL
{
    public class CartItem
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual string CartItemId { get; set; }

        // Number of this item in the cart
        public virtual int Quantity { get; set; }

        // When this item as added to the cart
        public virtual DateTime DateCreated { get; set; }
        // Foreign Key
        public virtual string ProductId { get; set; }

        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }

        // Foreign Key
        public virtual string CartId { get; set; }

        // Cart item is associated with.
        [ForeignKey("CartId")]
        public virtual ShoppingCart ShoppingCart { get; set; }
    }
}
