using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using XnNationalDefenseMobilize.Models.Master;

namespace XnNationalDefenseMobilize.Models.Home
{
    public class HomeViewModel
    {
        public MasterViewModel masterView { get; set; }

        public HomeViewModel()
        {
            masterView = new MasterViewModel();
        }
    }
}