using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace XnNationalDefenseMobilize.Models.Slogan
{
    public class SloganContext : DbContext
    {
        public SloganContext()
            : base("name=Slogan-Context")
        {
        }

        public DbSet<Slogan> sloganLists { get; set; }
    }
}