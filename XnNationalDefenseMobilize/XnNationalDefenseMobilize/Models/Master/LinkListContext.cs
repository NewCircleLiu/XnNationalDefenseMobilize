using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace XnNationalDefenseMobilize.Models.Master
{
    public class LinkListContext : DbContext
    {
        public LinkListContext()
            : base("name=LinkList-Context")
        {
        }

        public DbSet<LinkList> linkLists { get; set; }
    }
}