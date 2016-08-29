using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace XnNationalDefenseMobilize.Models.PolycyAdvice
{
    public class MessageContext : DbContext
    {
        public MessageContext()
            : base("name=Message-Context")
        {
        }

        public DbSet<Message> messageLists { get; set; }
    }
}