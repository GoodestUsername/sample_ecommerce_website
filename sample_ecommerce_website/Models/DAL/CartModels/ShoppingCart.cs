using Microsoft.AspNetCore.Identity;
using sample_ecommerce_website.Models.DAL;
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
        public virtual string CartId { get; set; }

        // total value of the cart
        public virtual double Total { get; set; }

        // Number of items in the cart
        public virtual int ItemQuantity { get; set; }

        // delete later
        // foreign key from user
        [PersonalData]
        public virtual string Id { get; set; }

        [ForeignKey("Id")]
        public virtual ApplicationUser User { get; set; }

        // items in the cart
        public virtual ICollection<CartItem> CartItems { get; set; }
    }
}
