using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace XnNationalDefenseMobilize.Models.Master
{
    public class ContactContext : DbContext
    {
        public ContactContext()
            : base("name=Contact-Context")
        {
        }

        public DbSet<Contact> ContactLists { get; set; }
    }
}