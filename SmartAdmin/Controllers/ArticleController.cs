using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Smart.Admin.Controllers
{
    /// <summary>
    /// 门户基础模块:文章管理
    /// </summary>
    [Filter.DefaultAuthorizationFilter]
    [Filter.DefaultLoggerActionFilter]
    public class ArticleController : Controller
    {
        //
        // GET: /Article/
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(string title, string content, string date, string username, string author)
        {
            return View();
        }

    }
}
