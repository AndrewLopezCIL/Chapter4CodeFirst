using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Chapter4CodeFirst.Models
{
    public class StoresModels
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int StoreID { get; set; }
        public string StoreName { get; set; }

        public virtual ICollection<BundlesModels> BundlesModels{ get; set; }
    }
}