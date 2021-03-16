using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StoreModels;
using System.ComponentModel;

namespace StoreMVC.Models
{
    public class InventoryCRVM
    {
        public int ProductId { get; set; }
        public string InventoryName { get; set; }
        public int InventoryPrice { get; set; }
        public int InventoryQuantity { get; set; }
        public int LocationId { get; set; }
    }
}
