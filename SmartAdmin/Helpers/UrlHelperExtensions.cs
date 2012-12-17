using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Smart.Admin.Helpers
{
    /// <summary>
    /// UrlHelper扩展
    /// </summary>
    public static class UrlHelperExtensions
    {
        /// <summary>
        /// 带有Areas的url地址(链接)
        /// </summary>
        /// <param name="url"></param>
        /// <param name="path"></param>
        /// <returns></returns>
        public static string ContentArea(this UrlHelper url, string path)
        {
            var area = url.RequestContext.RouteData.DataTokens["area"];

            if (area != null)
            {
                /*
                if (!string.IsNullOrEmpty(area.ToString()))
                    area = "Areas/" + area;
                */

                if (path.StartsWith("~/"))
                    path = path.Remove(0, 2);

                if (path.StartsWith("/"))
                    path = path.Remove(0, 1);

                path = path.Replace("../", string.Empty);

                return VirtualPathUtility.ToAbsolute("~/" + area + "/" + path);
            }

            return string.Empty;
        }

        /// <summary>
        /// 带有Areas的url地址(素材)
        /// </summary>
        /// <param name="url"></param>
        /// <param name="path"></param>
        /// <returns></returns>
        public static string ContentAreaMaterial(this UrlHelper url, string path)
        {
            var area = url.RequestContext.RouteData.DataTokens["area"];

            if (area != null)
            {
                if (!string.IsNullOrEmpty(area.ToString()))
                    area = "Areas/" + area;

                if (path.StartsWith("~/"))
                    path = path.Remove(0, 2);

                if (path.StartsWith("/"))
                    path = path.Remove(0, 1);

                path = path.Replace("../", string.Empty);

                return VirtualPathUtility.ToAbsolute("~/" + area + "/" + path);
            }

            return string.Empty;
        }
    }
}