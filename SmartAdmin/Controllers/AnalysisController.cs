using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Smart.Admin.Controllers
{
    /// <summary>
    /// 访客分析
    /// 分析网站的访客流量、设置第三方统计代码等。
    /// </summary>
    public class AnalysisController : Controller
    {
        //
        // GET: /Analysis/

        public ActionResult Index()
        {
            return View();
        }

    }
}
