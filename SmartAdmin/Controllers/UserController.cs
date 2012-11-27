using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Smart.Admin.Controllers
{
    /// <summary>
    /// 用户管理
    /// 网站管理员、职员、会员账户管理。
    /// </summary>
    public class UserController : Controller
    {
        //
        // GET: /User/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Del()
        {
            return View();
        }

        [HttpGet]
        public ActionResult List(int currentPage,int pageSize)
        {
            return View();
        }

    }
}
