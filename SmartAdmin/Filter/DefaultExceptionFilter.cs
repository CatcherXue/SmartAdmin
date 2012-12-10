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
            //记录错误日志
            /*
            string logText = string.Format("{0}\t{1}\t{2}\t{3}\t{4}\r\n",
                DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                filterContext.HttpContext.Request.Browser.Browser,
                filterContext.HttpContext.Request.UserHostAddress,
                filterContext.HttpContext.Request.Url.AbsoluteUri,
                filterContext.Exception.StackTrace);

            System.IO.File.AppendAllText(
                filterContext.HttpContext.Server.MapPath("~/") + "log.txt",
                logText);
            */

            //必须标记为已处理
            filterContext.ExceptionHandled = true;

            //跳转到错误处理页面
            //filterContext.HttpContext.Response.StatusCode = 303;
            filterContext.Result = new RedirectResult("~/Exception/Index", false);
        }
    }
}