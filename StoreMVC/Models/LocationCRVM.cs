using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using StoreModels;

namespace StoreMVC.Models
{
    public class LocationCRVM
    {
        [DisplayName("Location Address")]
        public string LocationAddress { get; set; }
        public int LocationID { get; set; }
    }
}
