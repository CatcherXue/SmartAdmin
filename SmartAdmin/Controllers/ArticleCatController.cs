using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;

namespace Smart.Admin.Controllers
{
    /// <summary>
    /// 门户基础模块:文章类目管理
    /// </summary>
    [Filter.DefaultAuthorizationFilter]
    [Filter.DefaultLoggerActionFilter]
    [Filter.DefaultExceptionFilter]
    public class ArticleCatController : Controller
    {
        private Models.SmartAdminDB smartAdminDB = new Models.SmartAdminDB();

        public ActionResult Index()
        {
            var data = from m in smartAdminDB.ArticleCats
                       select m;

            return View(data);
        }

        [HttpGet]
        public ActionResult Add()
        {
            Models.ArticleCat entity = new Models.ArticleCat();

            entity.Status = "normal";
            entity.IsParent = true;

            return View(entity);
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Add(Models.ArticleCat entity)
        {
            smartAdminDB.ArticleCats.Add(entity);

            string title = "添加类目提示";
            string message = "添加类目成功。";
            string callBackUrl = "~/ArticleCat/Index";
            if (smartAdminDB.SaveChanges() <= 0)
            {
                message = "添加类目失败。";
                callBackUrl = Request.Url.AbsoluteUri;
            }

            return RedirectToAction("Alert", new
            {
                callBackUrl = callBackUrl,
                title = title,
                content = message
            });
        }

        [HttpGet]
        public ActionResult Edit(int cid)
        {
            var data = from m in smartAdminDB.ArticleCats
                       where m.Cid == cid
                       select m;

            return View(data.First<Models.ArticleCat>());
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Edit(Models.ArticleCat entity)
        {
            smartAdminDB.ArticleCats.Attach(entity);
            smartAdminDB.Entry(entity).State = EntityState.Modified;

            string title = "编辑类目提示";
            string message = "编辑类目成功。";
            string callBackUrl = "~/ArticleCat/Index";
            if (smartAdminDB.SaveChanges() <= 0)
            {
                message = "编辑类目失败。";
                callBackUrl = Request.Url.AbsoluteUri;
            }

            return RedirectToAction("Alert", new
            {
                callBackUrl = callBackUrl,
                title = title,
                content = message
            });
        }

        [HttpGet]
        public ActionResult Del(int cid)
        {
            var data = from m in smartAdminDB.ArticleCats
                       where m.Cid == cid
                       select m;

            smartAdminDB.Entry(data.First<Models.ArticleCat>()).State = EntityState.Deleted;

            string title = "删除类目提示";
            string message = "删除类目成功。";
            string callBackUrl = "~/ArticleCat/Index";
            if (smartAdminDB.SaveChanges() <= 0)
            {
                message = "删除类目失败。";
                callBackUrl = Request.Url.AbsoluteUri;
            }

            return RedirectToAction("Alert", new
            {
                callBackUrl = callBackUrl,
                title = title,
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
