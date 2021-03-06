using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using StoreModels;

namespace StoreMVC.Models
{
    public class ProductIndexVM
    {
        [DisplayName("Product Name")]
        public string ProductName { get; set; }
        public int ProductID { get; set; }
        [DisplayName("Product Description")]
        public string ProductDescription { get; set; }
        [DisplayName("Product Price")]
        public double ProductPrice { get; set; }
    }
}
