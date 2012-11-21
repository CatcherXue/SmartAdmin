using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SmartAdmin.Controllers
{
    /// <summary>
    /// 用户后台页面登录控制器
    /// </summary>
    public class AdminController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public void Login(string username, string password, string verifyCode)
        {
            //用户登录校验

            //登录成功返回后台默认首页,否则返回登录页面
            RedirectToAction("user/index");

            //return View();
        }

        [HttpGet]
        public ActionResult LoginOut()
        {
            return View();
        }
    }
}