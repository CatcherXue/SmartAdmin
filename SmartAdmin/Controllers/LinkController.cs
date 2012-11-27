using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Smart.Admin.Controllers
{
    /// <summary>
    /// 门户基础模块:链接管理
    /// </summary>
    public class LinkController : Controller
    {
        //
        // GET: /Link/

        public ActionResult Index()
        {
            return View();
        }

    }
}
