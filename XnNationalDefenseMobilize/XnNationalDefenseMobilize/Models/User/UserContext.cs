using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace XnNationalDefenseMobilize.Models.User
{
    public class UserContext : DbContext
    {
        public UserContext()
            : base("name=User-Context")
        {
        }

        public DbSet<Rights> rightsoLists { get; set; }
        public DbSet<User> userLists { get; set; }
    }
}