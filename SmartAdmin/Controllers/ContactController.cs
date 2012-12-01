using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Smart.Admin.Controllers
{
    /// <summary>
    /// 门户基础模块:联系方式
    /// </summary>
    [Filter.DefaultAuthorizationFilter]
    [Filter.DefaultLoggerActionFilter]
    public class ContactController : Controller
    {
        //
        // GET: /Contact/

        public ActionResult Index()
        {
            return View();
        }

    }
}
