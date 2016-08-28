using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace XnNationalDefenseMobilize.Models.DefenseMobilize
{
    public class DefenseCategoryContext: DbContext
    {
        public DefenseCategoryContext()
            : base("name=DefenseCategory-Context")
        {
        }

        public DbSet<DefenseCategory> defenseCategoryLists { get; set; }
    }
}