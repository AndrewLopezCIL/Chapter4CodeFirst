using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Chapter4CodeFirst.Models
{
    public class VRHeadsetModels
    {
        [Key]
        public int HeadsetID { get; set; }

        public double Price { get; set; } 
        public string AvailableStoreName { get; set; }
        public string HeadsetName { get; set; }

        public virtual ICollection<BundlesModels> BundlesModels { get; set; }
    }
}