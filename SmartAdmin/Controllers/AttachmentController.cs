using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Smart.Admin.Controllers
{
    /// <summary>
    /// 门户基础模块:附件管理
    /// </summary>
    public class AttachmentController : Controller
    {
        //
        // GET: /Attachment/

        public ActionResult Index()
        {
            return View();
        }

    }
}
