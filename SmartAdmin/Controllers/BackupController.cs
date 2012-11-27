using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Smart.Admin.Controllers
{
    /// <summary>
    /// 备份恢复
    /// 备份恢复数据库。
    /// </summary>
    public class BackupController : Controller
    {
        //
        // GET: /Backup/

        public ActionResult Index()
        {
            return View();
        }

    }
}
