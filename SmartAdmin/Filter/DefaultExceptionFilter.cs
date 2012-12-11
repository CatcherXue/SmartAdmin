using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Smart.Admin.Filter
{
    /// <summary>
    /// 默认异常处理过滤器
    /// </summary>
    public class DefaultExceptionFilter : HandleErrorAttribute
    {
        private Smart.Admin.Models.SmartAdminDB smartAdminDB = new Models.SmartAdminDB();

        // 摘要:
        //     在发生异常时调用。
        //
        // 参数:
        //   filterContext:
        //     操作-筛选器上下文。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     filterContext 参数为 null。
        public override void OnException(ExceptionContext filterContext)
        {
            //记录异常日志
            Models.Logger entity = new Models.Logger();

            //save log entity to db
            //
            //smartAdminDB.SaveChanges();

            //filterContext.HttpContext.Session["HandleErrorAttribute"] = this;
        }
    }
}