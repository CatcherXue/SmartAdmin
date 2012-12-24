using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;

namespace Smart.Admin.Controllers
{
    /// <summary>
    /// 门户基础模块:文章管理
    /// </summary>
    [Filter.DefaultAuthorizationFilter]
    [Filter.DefaultLoggerActionFilter]
    [Filter.DefaultExceptionFilter]
    public class ArticleController : Controller
    {
        private Models.SmartAdminDB smartAdminDB = new Models.SmartAdminDB();

        public ActionResult Index()
        {
            var data = from m in smartAdminDB.Articles
                       orderby m.PublishTime descending
                       select m;

            return View(data);
        }

        [HttpGet]
        public ActionResult Add()
        {
            Models.Article entity = new Models.Article();

            entity.PublishTime = DateTime.Now;

            return View(entity);
        }

        [HttpGet]
        public ActionResult Copy(int id)
        {
            Models.Article entity = (from m in smartAdminDB.Articles
                                     where m.ID == id
                                     select m).First();
            entity.PublishTime = DateTime.Now;
            smartAdminDB.Articles.Add(entity);
            smartAdminDB.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Add(Models.Article entity)
        {
            smartAdminDB.Articles.Add(entity);

            string title = "添加文章提示";
            string message = "添加文章成功。";
            string callBackUrl = "~/Article/Index";
            if (smartAdminDB.SaveChanges() <= 0)
            {
                message = "添加文章失败。";
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
        public ActionResult Edit(int id)
        {
            var data = from m in smartAdminDB.Articles
                       where m.ID == id
                       select m;

            return View(data.First<Models.Article>());
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Edit(Models.Article entity)
        {
            smartAdminDB.Articles.Attach(entity);
            smartAdminDB.Entry(entity).State = EntityState.Modified;

            string title = "编辑文章提示";
            string message = "编辑文章成功。";
            string callBackUrl = "~/Article/Index";
            if (smartAdminDB.SaveChanges() <= 0)
            {
                message = "编辑文章失败。";
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
        public ActionResult Del(int id)
        {
            var data = from m in smartAdminDB.Articles
                       where m.ID == id
                       select m;

            smartAdminDB.Entry(data.First<Models.Article>()).State = EntityState.Deleted;

            string title = "删除文章提示";
            string message = "删除文章成功。";
            string callBackUrl = "~/Article/Index";
            if (smartAdminDB.SaveChanges() <= 0)
            {
                message = "删除文章失败。";
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