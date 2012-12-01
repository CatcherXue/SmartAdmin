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
    public class DefaultExceptionFilter: IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            throw new NotImplementedException();
            //to do:重定向到异常处理页面
            //filterContext.HttpContext.Response.Redirect("~/Exception/Index", true);
        }
    }
}