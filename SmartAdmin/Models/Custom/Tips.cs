using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Smart.Admin.Models.Custom
{
    /// <summary>
    /// 便捷提示信息模型
    /// </summary>
    public class Tips
    {
        /// <summary>
        /// 提示主题
        /// </summary>
        [DisplayName("提示主题")]
        public string Title { get; set; }

        /// <summary>
        /// 提示内容
        /// </summary>
        [DisplayName("提示内容")]
        public string Content { get; set; }

        /// <summary>
        /// 链接文本
        /// </summary>
        [DisplayName("链接文本")]
        public string LinkText { get; set; }

        /// <summary>
        /// 引用链接
        /// </summary>
        [DisplayName("引用链接")]
        public string Link { get; set; }
    }
}