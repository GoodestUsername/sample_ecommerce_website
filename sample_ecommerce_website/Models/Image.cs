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
        [Required(ErrorMessage = "ID is required")]
        public string ImageID { get; set; }

        // Image url as string
        [Required(ErrorMessage = "At least one image url is required")]
        public string ImageURL { get; set; }

        public virtual string ProductID { get; set; }

        [ForeignKey("ProductID")]
        public virtual Product Product { get; set; }
    }
}
