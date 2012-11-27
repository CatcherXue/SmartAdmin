using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Smart.Admin.Controllers
{
    /// <summary>
    /// 系统设置
    /// 提供系统安装、维护等功能。
    /// </summary>
    public class SystemController : Controller
    {
        /// <summary>
        /// 默认页面，如果系统未安装跳转到登录页面；如果用户未登录，跳转到登录页面。
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Index()
        {
            return View("~/Views/System/Login.cshtml");
        }

        /// <summary>
        /// 安装系统
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Install()
        {
            return View();
        }

        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="username">用户名</param>
        /// <param name="password">登录密码</param>
        /// <param name="code">验证码</param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Login(string username, string password, string code)
        {
            return View();
        }
                
        /// <summary>
        /// 登录页面
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        /// <summary>
        /// 退出登录
        /// </summary>
        /// <param name="username">用户名</param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult LoginOut(string username)
        {
            return View();
        }

        /// <summary>
        /// 获取一张验证码图片
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult VerificationCode()
        {
            return View();
        }
    }
}
