using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace XnNationalDefenseMobilize.Models.Home
{
    public class HomeImageContext : DbContext
    {
        public HomeImageContext()
            : base("name=HomeImage-Context")
        {
        }

        public DbSet<HomeImage> homeImageLists { get; set; }
    }
}