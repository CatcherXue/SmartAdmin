using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Smart.Admin.Controllers
{
    /// <summary>
    /// 开放接口
    /// 提供第三方调用API接口功能，用于第三方采集器连接、自动发布等。
    /// </summary>
    public class InterfaceController : Controller
    {
        //
        // GET: /Interface/

        public ActionResult Index()
        {
            return View();
        }

    }
}
