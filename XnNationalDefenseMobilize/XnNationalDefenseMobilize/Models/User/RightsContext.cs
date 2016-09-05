using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace XnNationalDefenseMobilize.Models.User
{
    public class RightsContext : DbContext
    {
        public RightsContext()
            : base("name=Rights-Context")
        {
        }

        public DbSet<Rights> rightsoLists { get; set; }
    }
}