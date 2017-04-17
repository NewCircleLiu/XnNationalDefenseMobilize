using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace XnNationalDefenseMobilize.Models.Conscript
{
    public class ConscriptPolicy
    {
            [Key]
            public int conscriptPolicy_id { get; set; }
            public string conscriptPolicy_title { get; set; }
            public string conscriptPolicy_source { get; set; }
            public string conscriptPolicy_abstract { get; set; }
            public string conscriptPolicy_content { get; set; }
            public DateTime conscriptPolicy_release_time { get; set; }

            public int conscriptPolicyCategory_id { get; set; }

            public virtual ConscriptPolicyCategory conscriptPolicyCate { get; set; }
    }
}