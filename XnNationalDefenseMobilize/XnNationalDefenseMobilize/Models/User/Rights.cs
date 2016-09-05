using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace XnNationalDefenseMobilize.Models.User
{
    public class Rights
    {
        [Key]
        public int rights_id { get; set; }
        public string rights_role_name { get; set; }
        public string rights_content { get; set; }

        public virtual ICollection<User> users { get; set; }
    }
}