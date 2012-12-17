using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Smart.Admin.Models.Custom
{
    /// <summary>
    /// 快捷菜单模型
    /// </summary>
    public class QuickMenu
    {
        /// <summary>
        /// 菜单图标
        /// </summary>
        [DisplayName("菜单图标")]
        public string Icon { get; set; }

        /// <summary>
        /// 链接文本
        /// </summary>
        [DisplayName("链接文本")]
        public string LinkText { get; set; }

        /// <summary>
        /// 链接地址
        /// </summary>
        [DisplayName("链接地址")]
        public string Link { get; set; }

        /// <summary>
        /// 链接描述
        /// </summary>
        [DisplayName("链接描述")]
        public string Description { get; set; }
    }
}