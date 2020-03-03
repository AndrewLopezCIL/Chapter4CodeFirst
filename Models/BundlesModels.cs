using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Chapter4CodeFirst.Models
{
    public class BundlesModels
    { 
        [Key]
        public int BundleID { get; set; }
        public int HeadsetBundledID { get; set; }
        public string BundledItem { get; set; }
    }
}