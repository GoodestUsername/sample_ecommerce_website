using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace sample_ecommerce_website.Models
{
    public class OrderDetails
    {
        // Order Details Id
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual string OrderDetailsId { get; set; }

        // the total cost of the order
        public virtual int Cost { get; set; }

        // foreign key from user
        [PersonalData]
        public virtual Guid Id { get; set; }

        [ForeignKey("Id")]
        public virtual User User { get; set; }

        public virtual UserAddress BillingAddress { get; set; }

        public virtual UserAddress ShippingAddress { get; set; }

        // Payment provIder
        public virtual string Provider { get; }

        // Status of the payment
        public virtual string Status { get; set; }

        // time and date order was created
        public virtual DateTime OrderCreationDate { get; }

        // time and date order was last modified
        public virtual DateTime OrderModificationDate { get; set; }

        // items in the cart
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
