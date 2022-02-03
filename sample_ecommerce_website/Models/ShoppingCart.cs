using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
/// <summary>
/// Shopping cart class
/// </summary>
namespace sample_ecommerce_website.Models
{
    public class ShoppingCart
    {
        // id of shopping cart
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string CartID { get; set; }

        // total value of the cart
        public double Total { get; set; }

        // Number of items in the cart
        public int ItemQuantity { get; set; }

        // foreign key from user
        [PersonalData]
        public virtual Guid Id { get; set; }

        [ForeignKey("Id")]
        public virtual User User { get; set; }

        // items in the card
        public virtual ICollection<Product> CartItems { get; set; }
    }
}
