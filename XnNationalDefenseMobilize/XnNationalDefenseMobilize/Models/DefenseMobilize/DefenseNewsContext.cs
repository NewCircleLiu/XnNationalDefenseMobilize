using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace XnNationalDefenseMobilize.Models.DefenseMobilize
{
    public class DefenseNewsContext: DbContext
    {
        public DefenseNewsContext()
            : base("name=DefenseNews-Context")
        {
        }

        public DbSet<DefenseNews> defenseNewsLists { get; set; }
    }
}