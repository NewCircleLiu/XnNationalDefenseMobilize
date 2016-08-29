using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace XnNationalDefenseMobilize.Models.PolycyAdvice
{
    public class CommonQuesContext : DbContext
    {
        public CommonQuesContext()
            : base("name=CommonQues-Context")
        {
        }

        public DbSet<CommonQues> commonQuesLists { get; set; }
    }
}