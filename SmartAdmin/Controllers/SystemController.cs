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
    [Filter.DefaultLoggerActionFilter]
    public class SystemController : Controller
    {
        /// <summary>
        /// 默认页面，如果系统未安装跳转到登录页面；如果用户未登录，跳转到登录页面。
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Filter.DefaultAuthorizationFilter]
        public ActionResult Index()
        {
            //return View("~/Views/System/Login.cshtml");
            return View();
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
        /// <param name="remember">保存用户名到Cookie中</param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Login(string username, string password, string code, string remember)
        {
            Response.Cookies.Add(new HttpCookie("username", username));

            //一周内免登陆设置
            if (remember == "1")
            {
                //保存用户名
                Response.Cookies.Add(new HttpCookie("issave", username) { Expires = DateTime.Now.AddDays(7) });
            }
            
            //登录成功后,跳转到后台默认主页
            return RedirectToAction("Index", "System");
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
        [Filter.DefaultAuthorizationFilter]
        public ActionResult LoginOut(string username)
        {
            Response.Cookies.Add(new HttpCookie("username", ""));
            //return View("~/Views/System/Login.cshtml");

            return new RedirectResult("~/System/Login", false);
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
