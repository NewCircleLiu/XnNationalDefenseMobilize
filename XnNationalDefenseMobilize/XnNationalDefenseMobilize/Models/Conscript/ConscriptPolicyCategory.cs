using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace XnNationalDefenseMobilize.Models.Conscript
{
    public class ConscriptPolicyCategory
    {
        [Key]
        public int conscriptPolicyCategory_id { get; set; }
        public string conscriptPolicyCategory_name { get; set; }

        public virtual ICollection<ConscriptPolicy> ConscriptPolicys { get; set; }
    }
}