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
        // Order Details ID
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string OrderDetailsID { get; set; }

        // the total cost of the order
        public virtual int Cost { get; set; }

        // foreign key from user
        [PersonalData]
        public virtual Guid Id { get; set; }

        [ForeignKey("Id")]
        public virtual User User { get; set; }

        public virtual UserAddress BillingAddress { get; set; }

        public virtual UserAddress ShippingAddress { get; set; }

        // Payment provider
        public string Provider { get; }

        // Status of the payment
        public string Status { get; set; }

        // time and date order was created
        public DateTime OrderCreationDate { get; }

        // time and date order was last modified
        public DateTime OrderModificationDate { get; set; }

        // items in the card
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
