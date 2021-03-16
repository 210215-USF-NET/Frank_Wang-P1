using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;

namespace StoreMVC.Models
{
    public class LocationIndexVM
    {
        [DisplayName("Location Address")]
        public string LocationAddress { get; set; }
        public int LocationID { get; set; }
        
    }
}
