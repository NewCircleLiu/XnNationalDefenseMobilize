using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace XnNationalDefenseMobilize.Models.DefenseMobilize
{
    public class DefenseCategory
    {
        [Key]
        public int defenseCategory_id { get; set; }
        public string defenseCategory_name { get; set; }

        public virtual ICollection<DefenseNews> defenseNews { get; set; }
    }
}