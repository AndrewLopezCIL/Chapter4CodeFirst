using Chapter4CodeFirst.Models;
using System;
using System.Collections.Generic; 
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Chapter4CodeFirst.DAL
{
    public class VRContext : DbContext
    {
        public VRContext() : base("VRContext")
        {
        } 
        public DbSet<StoresModels> StoresModels { get; set; }
        public DbSet<VRHeadsetModels> VRHeadsetModels { get; set; }
        public DbSet<BundlesModels> BundlesModels { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}