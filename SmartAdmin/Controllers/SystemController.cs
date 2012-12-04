using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Smart.Admin;
using System.Drawing;

namespace Smart.Admin.Controllers
{
    /// <summary>
    /// 系统设置
    /// 提供系统安装、维护等功能。
    /// </summary>
    [Filter.DefaultLoggerActionFilter]
    public class SystemController : Controller
    {
        Models.SmartAdminDB smartAdminDB = new Models.SmartAdminDB();

        /// <summary>
        /// 默认页面，如果系统未安装跳转到登录页面；如果用户未登录，跳转到登录页面。
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Filter.DefaultAuthorizationFilter]
        public ActionResult Index()
        {
            //添加一条测试数据
            /*
            Models.User user = new Models.User();
            user.CurrentIPAddress = Request.UserHostAddress;
            user.EmailAddress = "smartbooks@qq.com";
            user.EndLoginDate = DateTime.Now;
            user.MutileOnLine = false;
            user.Nick = "飞翔的小鸟";
            user.OnLine = false;
            user.Password = "123456789";
            user.RegisterDate = DateTime.Now;
            user.UserName = new Random().Next(999999).ToString();
            user.UserRole = "超级管理员";

            smartAdminDB.Users.Add(user);

            smartAdminDB.SaveChanges();

            var data = from u in smartAdminDB.Users
                       //where u.UserName == user.UserName
                       orderby u.RegisterDate descending
                       select u;
            
            ViewBag.Data = data;
            */
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
            //校验验证码
            if (Session["validatecode"] == null || Session["validatecode"].ToString() != code)
            {
                //校验失败,返回登录页面
                ViewBag.Message = "验证码错误。";
                return View("~/Views/System/Login.cshtml");
            }

            //校验用户名和密码

            //校验通过

            //一周内免登陆设置
            if (remember == "1")
            {
                Response.Cookies.Add(new HttpCookie("username", username) { Expires = DateTime.Now.AddDays(7) });
            }
            else
            {
                Response.Cookies.Add(new HttpCookie("username", username));
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
        public void VerificationCode()
        {
            //构造验证码图片
            Smart.Utility.ValidateCode validateCode = new Utility.ValidateCode();
            validateCode.Border = true;
            validateCode.BorderColor = Color.Red;
            validateCode.BorderWidth = 1;
            validateCode.Chaos = true;
            validateCode.Colors = new Color[] { Color.Red, Color.Gray, Color.Blue, Color.Beige };
            validateCode.FontSize = 13;
            validateCode.Length = 4;
            validateCode.Padding = 1;

            //生成随机数字
            Random rd = new Random();
            string codeText = string.Format("{0}{1}{2}{3}",
                rd.Next(0, 9).ToString(),
                rd.Next(0, 9).ToString(),
                rd.Next(0, 9).ToString(),
                rd.Next(0, 9).ToString());

            //验证码文本加入Session
            this.Session["validatecode"] = codeText;

            //向客户端返回一张验证码图片
            Bitmap image = validateCode.CreateImageCode(codeText);
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            this.Response.ClearContent();
            this.Response.ContentType = "image/png";
            this.Response.BinaryWrite(ms.GetBuffer());
            ms.Close();
            ms = null;
            image.Dispose();
            image = null;
        }
    }
}
