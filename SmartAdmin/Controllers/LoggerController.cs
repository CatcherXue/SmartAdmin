using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Smart.Admin.Controllers
{
    /// <summary>
    /// 日志管理
    /// 网站访问日志管理。
    /// </summary>
    public class LoggerController : Controller
    {
        //
        // GET: /Logger/

        public ActionResult Index()
        {
            return View();
        }

    }
}
