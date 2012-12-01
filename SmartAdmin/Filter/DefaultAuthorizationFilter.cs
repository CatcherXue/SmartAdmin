using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Smart.Admin.Filter
{
    /// <summary>
    /// 默认用户访问授权验证过滤器
    /// </summary>
    public class DefaultAuthorizationFilter : AuthorizeAttribute
    {
        //
        // 摘要:
        //     处理授权失败的 HTTP 请求。
        //
        // 参数:
        //   filterContext:
        //     封装用于 System.Web.Mvc.AuthorizeAttribute 的信息。 filterContext 对象包括控制器、HTTP 上下文、请求上下文、操作结果和路由数据。
        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            //filterContext.Result = new RedirectResult("~/System/Login");
        }
        //
        // 摘要:
        //     在过程请求授权时调用。
        //
        // 参数:
        //   filterContext:
        //     筛选器上下文，它封装用于 System.Web.Mvc.AuthorizeAttribute 的信息。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     filterContext 参数为 null。
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            if (filterContext.HttpContext.Request.Cookies["username"] == null)
            {
                //无权限访问
                filterContext.HttpContext.Response.StatusCode = 401;
                filterContext.Result = new RedirectResult("~/System/Login", false);
            }
            else
            {
                this.Users = filterContext.HttpContext.Request.Cookies["username"].Value;
                this.Roles = "超级管理员";
            }
        }
        //
        // 摘要:
        //     在缓存模块请求授权时调用。
        //
        // 参数:
        //   httpContext:
        //     HTTP 上下文，它封装有关单个 HTTP 请求的所有 HTTP 特定的信息。
        //
        // 返回结果:
        //     对验证状态的引用。
        //
        // 异常:
        //   System.ArgumentNullException:
        //     httpContext 参数为 null。
        protected override HttpValidationStatus OnCacheAuthorization(HttpContextBase httpContext)
        {
            return HttpValidationStatus.Invalid;
        }
    }
}