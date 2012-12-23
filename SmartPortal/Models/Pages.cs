using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Smart.Portal.Models
{
    /// <summary>
    /// 通用分页模型
    /// </summary>
    public class Pages
    {
        /// <summary>
        /// 页码总数
        /// </summary>
        public int PageCount { get; set; }

        /// <summary>
        /// 每页记录数
        /// </summary>
        public int PageSize { get; set; }

        /// <summary>
        /// 当前页码
        /// </summary>
        public int CurrentPage { get; set; }

        /// <summary>
        /// 数据源
        /// </summary>
        public object DataSource { get; set; }
    }
}