using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Smart.Admin;
using System.Data.Entity;

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
        private Smart.Admin.Models.SmartAdminDB smartAdminDB = new Models.SmartAdminDB();

        public ActionResult Index()
        {
            var data = from m in smartAdminDB.Users
                       select m;

            return View(data);
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
            smartAdminDB.Users.Add(model);
            smartAdminDB.SaveChanges();

            return RedirectToAction("Index");

            //return View(model);
        }

        [HttpGet]
        public ActionResult Edit(string userName)
        {
            //Get by username model
            var data = from m in smartAdminDB.Users
                       where m.UserName == userName
                       select m;

            return View(data.First<Models.User>());
        }

        [HttpPost]
        public ActionResult Edit(Models.User model)
        {
            smartAdminDB.Users.Attach(model);

            smartAdminDB.Entry(model).State =

            smartAdminDB.SaveChanges();

            return RedirectToAction("Index");

            //return View();
        }

        [HttpGet]
        public ActionResult Del(string userName)
        {
            var data = from m in smartAdminDB.Users
                       where m.UserName == userName
                       select m;

            smartAdminDB.Users.Remove(data.First<Smart.Admin.Models.User>());

            smartAdminDB.SaveChanges();

            this.ViewBag.Message = "用户删除成功";

            return View();
        }
    }
}
