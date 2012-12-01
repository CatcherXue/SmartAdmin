using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Smart.Admin.Controllers
{
    /// <summary>
    /// 默认异常处理控制器
    /// </summary>
    [Filter.DefaultLoggerActionFilter]
    public class ExceptionController : Controller
    {
        //
        // GET: /Exception/

        public ActionResult Index()
        {
            return View();
        }

    }
}
