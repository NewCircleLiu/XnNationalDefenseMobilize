using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace XnNationalDefenseMobilize.Models.News
{
    public class NewsInfoContext : DbContext
    {
        public NewsInfoContext()
            : base("name=NewsInfo-Context")
        {
        }

        public DbSet<NewsInfo> newsInfoLists { get; set; }
        public DbSet<NewsCategory> newsCategoryLists { get; set; }
    }
}