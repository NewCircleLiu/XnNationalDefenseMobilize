using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace XnNationalDefenseMobilize.Models.GrassrootWork
{
    public class DistrictContext : DbContext
    {
        public DistrictContext()
            : base("name=Distric-Context")
        {
        }

        public DbSet<District> DistrictLists { get; set; }
    }
}