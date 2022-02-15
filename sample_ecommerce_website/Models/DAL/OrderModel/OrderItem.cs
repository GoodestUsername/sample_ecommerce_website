using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace sample_ecommerce_website.Models
{
    public class OrderItem
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual string OrderItemId { get; set; }

        public virtual int Quantity { get; set; }

        public virtual string ProductId { get; set; }

        public virtual double Price { get; set; }

        // Foreign Key
        public virtual string OrderDetailsId { get; set; }

        // Order the item is associated with.
        [ForeignKey("OrderDetailsId")]
        public virtual OrderDetails Order { get; set; }
    }
}
