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
    public class ArticleController : Controller
    {
        //
        // GET: /Article/

        public ActionResult Index()
        {
            return View();
        }

    }
}
