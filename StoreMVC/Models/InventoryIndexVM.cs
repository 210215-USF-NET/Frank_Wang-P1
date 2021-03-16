using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using StoreModels;

namespace StoreMVC.Models
{
    public class InventoryIndexVM
    {
        public int LocationId { get; set; }
        public int ProductId { get; set; }
        public string InventoryName { get; set; }
        public int InventoryPrice { get; set; }
        public int InventoryQuantity { get; set; }
        
    }
}
