using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace XnNationalDefenseMobilize.Models.Master
{
    public class SuggestContext: DbContext
    {
        public SuggestContext()
            : base("name=Suggest-Context")
        {
        }

        public DbSet<Suggest> suggestLists { get; set; }
    }
}