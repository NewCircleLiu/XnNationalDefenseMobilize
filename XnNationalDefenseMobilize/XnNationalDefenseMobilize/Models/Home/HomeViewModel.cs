using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using XnNationalDefenseMobilize.Models.DefenseMobilize;
using XnNationalDefenseMobilize.Models.Master;
using XnNationalDefenseMobilize.Models.MediaImpress;
using XnNationalDefenseMobilize.Models.News;
using XnNationalDefenseMobilize.Models.Slogan;

namespace XnNationalDefenseMobilize.Models.Home
{
    public class HomeViewModel
    {
        public MasterViewModel masterView { get; set; }
        public List<HomeImage> homeImages { get; set; }
        public List<Slogan.Slogan> slogans { get; set; }
        public List<DefenseNews> defenseNews { get; set; }
        public List<NewsInfo> news { get; set; }
        public List<MediaImpress.MediaImpress> mediaImpress { get; set; }


        public HomeViewModel()
        {
            homeImages = new HomeImageContext().homeImageLists.ToList();

            DefenseNewsContext defenseContext = new DefenseNewsContext();
            defenseNews = (from item in defenseContext.defenseNewsLists
                           orderby item.defenseNews_release_time descending
                           select item).ToList();

            NewsInfoContext newsInfoContext = new NewsInfoContext();
            news = (from item in newsInfoContext.newsInfoLists
                    orderby item.new_release_time descending
                    select item).ToList();

            MediaImpressContext mediaImpressContext = new MediaImpressContext();
            mediaImpress = (from item in mediaImpressContext.mediaImpressLists
                            orderby item.mediaImpress_release_time descending
                            select item).ToList();

            slogans = new SloganContext().sloganLists.ToList();

            masterView = new MasterViewModel();
        }
    }
}