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
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string OrderItemID { get; set; }

        public int Quantity { get; set; }

        public string ProductID { get; set; }

        public double Price { get; set; }

        // Foreign Key
        public virtual string OrderDetailsID { get; set; }

        // Order the item is associated with.
        [ForeignKey("OrderDetailsID")]
        public virtual OrderDetails Order { get; set; }
    }
}
