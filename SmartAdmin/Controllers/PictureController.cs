using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Smart.Admin.Controllers
{
    /// <summary>
    /// 门户基础模块:图片管理
    /// </summary>
    [Filter.DefaultAuthorizationFilter]
    [Filter.DefaultLoggerActionFilter]
    [Filter.DefaultExceptionFilter]
    public class PictureController : Controller
    {
        //
        // GET: /Picture/

        public ActionResult Index()
        {
            return View();
        }

    }
}
