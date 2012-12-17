using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Smart.Portal.Controllers
{
    public class HomeController : Controller
    {
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
            Models.Pages page = new Models.Pages();
            page.CurrentPage = 1;
            page.PageCount = 10;
            page.PageSize = 20;
            page.DataSource = new List<string>();
            //page.DataSource.Add("01");

            return View(page);

        }

        /// <summary>
        /// 新闻资讯
        /// </summary>
        /// <returns></returns>
        public ActionResult News()
        {
            return View();
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
