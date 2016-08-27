using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace XnNationalDefenseMobilize.Models.News
{
    public class NewsCategoryContext : DbContext
    {
        public NewsCategoryContext()
            : base("name=NewsCategory-Context")
        {
        }

        public DbSet<NewsCategory> newsCategoryLists { get; set; }
    }
}