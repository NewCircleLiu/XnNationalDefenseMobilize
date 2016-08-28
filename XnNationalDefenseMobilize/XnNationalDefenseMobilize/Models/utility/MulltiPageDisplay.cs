using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using XnNationalDefenseMobilize.Models.News;
using XnNationalDefenseMobilize.Models.DefenseMobilize;

namespace XnNationalDefenseMobilize.Models.utility
{
    public class MulltiPageDisplayContrler
    {
        public int count_pages;         //总的页数
        public int items_in_apage;      //每页显示的条目数
        public int count_items;         //数据的数目
        public int curr_page_index;     //当前请求的页码
        public int start_item_index;    //当前页起始条目
        public int end_item_index;      //当前页终止条目
        public int start_page_index;    //显示的开始页码
        public int end_page_index;      //显示的结束页码
        public int link_num_in_apage;   //单页显示的页码链接数目
        public Object data = null;      //输入的数据
        public Object curr_page_data =null; //返回请求的数据

        /// <summary>
        /// obj ：输入的数据集合
        /// items_in_apage_：  单页显示的条目数
        /// link_num_in_apage_：单页显示的页码链接数目
        /// page_index: 当前请求的页码
        /// </summary> 
        public MulltiPageDisplayContrler(Object obj, int items_in_apage_,int link_num_in_apage_, int page_index)
        {
            data = obj;
            items_in_apage = items_in_apage_;
            curr_page_index = page_index;
            link_num_in_apage = link_num_in_apage_;

            GetData();
        }

        public void GetData()
        {
            if (data.GetType().ToString() == "System.Data.Entity.Infrastructure.DbQuery`1[XnNationalDefenseMobilize.Models.News.NewsInfo]")
            {
                IEnumerable<NewsInfo> newsItems = (IEnumerable<NewsInfo>)data;

                count_items = newsItems.Count();
                count_pages = (int)Math.Ceiling(count_items / (items_in_apage * 1.0)); //获取总的页数，去上整

                if (curr_page_index <= 0) curr_page_index = 1;  //当前页是第1页时，不能继续点击上一页
                if (curr_page_index >= count_pages) curr_page_index = count_pages;  //当前页是第最后1页时，不能继续点击下一页

                start_item_index = (curr_page_index - 1) * items_in_apage;  //当前页的第一项数据
                end_item_index = Math.Min(curr_page_index * items_in_apage, count_items); //当前页的最后一项数据

                start_page_index = ((curr_page_index - 1) / link_num_in_apage) * link_num_in_apage + 1; //显示的起始页码
                end_page_index = Math.Min(start_page_index + link_num_in_apage - 1, count_pages);   //显示的终止页码            

                curr_page_data = newsItems.ToList().GetRange(start_item_index, end_item_index - start_item_index);
            }

            else if (data.GetType().ToString() == "System.Data.Entity.Infrastructure.DbQuery`1[XnNationalDefenseMobilize.Models.DefenseMobilize.DefenseNews]")
            {
                IEnumerable<DefenseNews> newsItems = (IEnumerable<DefenseNews>)data;

                count_items = newsItems.Count();
                count_pages = (int)Math.Ceiling(count_items / (items_in_apage * 1.0)); //获取总的页数，去上整

                if (curr_page_index <= 0) curr_page_index = 1;  //当前页是第1页时，不能继续点击上一页
                if (curr_page_index >= count_pages) curr_page_index = count_pages;  //当前页是第最后1页时，不能继续点击下一页

                start_item_index = (curr_page_index - 1) * items_in_apage;  //当前页的第一项数据
                end_item_index = Math.Min(curr_page_index * items_in_apage, count_items); //当前页的最后一项数据

                start_page_index = ((curr_page_index - 1) / link_num_in_apage) * link_num_in_apage + 1; //显示的起始页码
                end_page_index = Math.Min(start_page_index + link_num_in_apage - 1, count_pages);   //显示的终止页码            

                curr_page_data = newsItems.ToList().GetRange(start_item_index, end_item_index - start_item_index);
            }
        }
    }
}