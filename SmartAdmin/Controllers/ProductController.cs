using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Smart.Admin.Controllers
{
    /// <summary>
    ///  门户基础模块:产品管理
    /// </summary>
    [Filter.DefaultAuthorizationFilter]
    [Filter.DefaultLoggerActionFilter]
    public class ProductController : Controller
    {
        //
        // GET: /Product/

        public ActionResult Index()
        {
            return View();
        }

    }
}
