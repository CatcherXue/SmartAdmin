using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Smart.Admin.Controllers
{
    /// <summary>
    /// 更新维护
    /// 提供建库、升级建库、补丁脚本、安全程序补丁更新维护功能。
    /// </summary>
    public class UpdateController : Controller
    {
        //
        // GET: /Update/

        public ActionResult Index()
        {
            return View();
        }

    }
}
