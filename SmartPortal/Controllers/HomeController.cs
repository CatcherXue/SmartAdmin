using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Smart.Admin.Models;
using Webdiyer.WebControls.Mvc;

namespace Smart.Portal.Controllers
{
    public class HomeController : Controller
    {
        private SmartAdminDB smartAdminDB = new SmartAdminDB();

        /// <summary>
        /// 网站首页
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 公司简介
        /// </summary>
        /// <returns></returns>
        public ActionResult CompanyProfile()
        {
            return View();
        }

        /// <summary>
        /// 产品展示
        /// </summary>
        /// <returns></returns>
        public ActionResult Products()
        {
            return View();
        }

        /// <summary>
        /// 新闻资讯
        /// </summary>
        /// <returns></returns>
        public ActionResult News(int page = 1, int size = 2)
        {
            var data = from m in smartAdminDB.Articles
                       orderby m.PublishTime descending
                       select m;

            PagedList<Admin.Models.Article> article = data.ToPagedList(page, size);

            return View(article);
        }

        /// <summary>
        /// 新闻详情
        /// </summary>
        /// <returns></returns>
        public ActionResult NewsDetail(int id)
        {
            var data = from m in smartAdminDB.Articles
                       where m.ID == id
                       select m;

            return View(data.First());
        }

        /// <summary>
        /// 产品知识
        /// </summary>
        /// <returns></returns>
        public ActionResult ProductsLore()
        {
            return View();
        }

        /// <summary>
        /// 销售网络
        /// </summary>
        /// <returns></returns>
        public ActionResult SalesNetwork()
        {
            return View();
        }

        /// <summary>
        /// 服务宗旨
        /// </summary>
        /// <returns></returns>
        public ActionResult Service()
        {
            return View();
        }

        /// <summary>
        /// 联系我们
        /// </summary>
        /// <returns></returns>
        public ActionResult Contact()
        {
            return View();
        }

        /// <summary>
        /// 关于网站
        /// </summary>
        /// <returns></returns>
        public ActionResult About()
        {
            return View();
        }

        /// <summary>
        /// 工作机会
        /// </summary>
        /// <returns></returns>
        public ActionResult Jobs()
        {
            return View();
        }

        /// <summary>
        /// 友情链接
        /// </summary>
        /// <returns></returns>
        public ActionResult Links()
        {
            return View();
        }

        /// <summary>
        /// 免责声明
        /// </summary>
        /// <returns></returns>
        public ActionResult Statement()
        {
            return View();
        }

        /// <summary>
        /// 法律事务
        /// </summary>
        /// <returns></returns>
        public ActionResult LegalAffairs()
        {
            return View();
        }

        /// <summary>
        /// 网站地图
        /// </summary>
        /// <returns></returns>
        public ActionResult SiteMap()
        {
            return View();
        }

        /// <summary>
        /// 帮助中心
        /// </summary>
        /// <returns></returns>
        public ActionResult Help()
        {
            return View();
        }

    }
}
