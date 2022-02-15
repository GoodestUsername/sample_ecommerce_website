using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace sample_ecommerce_website.Models
{
    /// <summary>
    /// Class that contains urls of images for an associated product.
    /// </summary>
    public class Image
    {
        // Image ID
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual string ImageId { get; set; }

        // Image url as string
        [Required(ErrorMessage = "At least one image url is required")]
        public virtual string ImageURL { get; set; }

        // Foreign key
        public virtual string ProductId { get; set; }

        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }
    }
}
