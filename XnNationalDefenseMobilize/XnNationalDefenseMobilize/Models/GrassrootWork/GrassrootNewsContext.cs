using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace XnNationalDefenseMobilize.Models.GrassrootWork
{
    public class GrassrootNewsContext : DbContext
    {
        public GrassrootNewsContext()
            : base("name=GrassrootNews-Context")
        {
        }

        public DbSet<GrassrootNews> grassrootNewsLists { get; set; }
    }
}