using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace XnNationalDefenseMobilize.Models.DefenseMobilize
{
    public class DefenseNews
    {
        [Key]
        public int defenseNews_id { get; set; }
        public string defenseNews_title { get; set; }
        public string defenseNews_author { get; set; }
        public string defenseNews_source { get; set; }
        public string defenseNews_abstract { get; set; }
        public string defenseNews_content { get; set; }

        public virtual DefenseCategory defenseNewsCategory { get; set; }
    }
}