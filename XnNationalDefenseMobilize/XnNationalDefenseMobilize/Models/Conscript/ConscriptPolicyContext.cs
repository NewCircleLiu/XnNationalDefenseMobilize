using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace XnNationalDefenseMobilize.Models.Conscript
{
    public class ConscriptPolicyContext:DbContext
    {
        public ConscriptPolicyContext()
            : base("name=NewsCategory-Context")
        {
        }

        public DbSet<ConscriptPolicy> conscriptPolicyLists { get; set; }
        public DbSet<ConscriptPolicyCategory> conscriptPolicyCategoryLists { get; set; }
    }
}