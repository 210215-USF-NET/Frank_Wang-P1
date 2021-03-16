using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace StoreMVC.Models
{
    public class ProductEditVM
    {
        [DisplayName("Product Name")]
        [Required]
        public string ProductName { get; set; }
        public int ProductID { get; set; }
        [DisplayName("Product Description")]
        [Required]
        public string ProductDescription { get; set; }
        [DisplayName("Product Price")]
        [Required]
        public double ProductPrice { get; set; }
    }
}

