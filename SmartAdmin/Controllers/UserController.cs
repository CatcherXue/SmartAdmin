using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Smart.Admin;

namespace Smart.Admin.Controllers
{
    using Smart.Admin;
    /// <summary>
    /// 用户管理
    /// 网站管理员、职员、会员账户管理。
    /// </summary>
    [Filter.DefaultAuthorizationFilter]
    [Filter.DefaultLoggerActionFilter]
    public class UserController : Controller
    {
        //
        // GET: /User/

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Add()
        {
            Models.User entity = new Models.User();
            entity.CurrentIPAddress = this.Request.UserHostAddress;
            entity.EmailAddress = "";
            entity.EndLoginDate = DateTime.Now;
            entity.MutileOnLine = false;
            entity.Nick = "";
            entity.OnLine = false;
            entity.Password = "";
            entity.RegisterDate = DateTime.Now;
            entity.UserName = "";
            entity.UserRole = "";

            return View(entity);
        }

        [HttpPost]
        public ActionResult Add(Models.User model)
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
