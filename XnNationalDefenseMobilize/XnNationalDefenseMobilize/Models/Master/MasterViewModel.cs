using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XnNationalDefenseMobilize.Models.Master
{
    public class MasterViewModel
    {
        public LinkListContext LinkTable { get; set; }
        public ContactContext ContactTable { get; set; }
        public SuggestContext SuggestTable { get; set; }

        public MasterViewModel()
        {
            LinkTable = new LinkListContext();
            ContactTable = new ContactContext();
            SuggestTable = new SuggestContext(); ;
        }
    }
}