using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Smart.Admin.Filter
{
    /// <summary>
    /// 默认日志记录器过滤器类
    /// </summary>
    public class DefaultLoggerActionFilter : ActionFilterAttribute
    {
        // 摘要:
        //     在执行操作方法后由 MVC 框架调用。
        //
        // 参数:
        //   filterContext:
        //     筛选器上下文。
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
        }
        //
        // 摘要:
        //     在执行操作方法之前由 MVC 框架调用。
        //
        // 参数:
        //   filterContext:
        //     筛选器上下文。
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            string logText = string.Format("{0}\t{1}\t{2}\t{3}\r\n",
                DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                filterContext.HttpContext.Request.Browser.Browser,
                filterContext.HttpContext.Request.UserHostAddress,
                filterContext.HttpContext.Request.Url.AbsoluteUri);

            System.IO.File.AppendAllText(
                filterContext.HttpContext.Server.MapPath("~/") + "log.txt",
                logText);
        }
        //
        // 摘要:
        //     在执行操作结果后由 MVC 框架调用。
        //
        // 参数:
        //   filterContext:
        //     筛选器上下文。
        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
        }
        //
        // 摘要:
        //     在执行操作结果之前由 MVC 框架调用。
        //
        // 参数:
        //   filterContext:
        //     筛选器上下文。
        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
        }
    }
}