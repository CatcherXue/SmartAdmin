using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Smart.Admin;
using System.Data;

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
            //解决Checkbox无法获取值问题
            model.OnLine = false;
            if (Request.Form["OnLine"].ToString().ToLower() == "true")
            {
                model.OnLine = true;
            }
            model.MutileOnLine = false;
            if (Request.Form["MutileOnLine"].ToString().ToLower() == "true")
            {
                model.MutileOnLine = true;
            }

            smartAdminDB.Users.Add(model);

            string message = "";

            if (smartAdminDB.SaveChanges() > 0)
            {
                message = "添加用户成功。";
            }
            else
            {
                message = "添加用户失败。";
            }

            return RedirectToAction("Alert", new
            {
                callBackUrl = "~/User/Add",
                title = "添加用户提示",
                content = message
            });
        }

        [HttpGet]
        public ActionResult Edit(string userName)
        {
            var data = from m in smartAdminDB.Users
                       where m.UserName == userName
                       select m;

            return View(data.First<Models.User>());
        }

        [HttpPost]
        public ActionResult Edit(Models.User model)
        {
            //解决checkbox值获取不到的问题
            model.OnLine = true;
            if (Request.Form["OnLine"] == null)
            {
                model.OnLine = false;
            }

            model.MutileOnLine = true;
            if (Request.Form["MutileOnLine"] == null)
            {
                model.MutileOnLine = false;
            }

            smartAdminDB.Users.Attach(model);

            //更改缓存修改状态
            smartAdminDB.Entry(model).State = EntityState.Modified;

            string message = "";

            if (smartAdminDB.SaveChanges() > 0)
            {
                message = "保存用户成功。";
            }
            else
            {
                message = "保存用户失败。";
            }

            return RedirectToAction("Alert", new
            {
                callBackUrl = "~/User/Index",
                title = "保存用户提示",
                content = message
            });
        }

        [HttpGet]
        public ActionResult Del(string userName)
        {
            var data = from m in smartAdminDB.Users
                       where m.UserName == userName
                       select m;

            smartAdminDB.Users.Remove(data.First<Smart.Admin.Models.User>());

            string message = "";

            if (smartAdminDB.SaveChanges() > 0)
            {
                message = "删除用户成功。";
            }
            else
            {
                message = "删除用户失败。";
            }

            return RedirectToAction("Alert", new
            {
                callBackUrl = "~/User/Index",
                title = "删除用户提示",
                content = message
            });
        }

        public ActionResult Alert(string callBackUrl, string title, string content)
        {
            this.ViewBag.ReferenceUrl = callBackUrl;
            this.ViewBag.Title = title;
            this.ViewBag.Content = content;
            return View();
        }
    }
}
