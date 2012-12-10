using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Smart.Admin.Models
{
    /// <summary>
    /// 文章信息实体
    /// </summary>
    public class Article
    {
        [Key]
        [DisplayName("文章标题")]
        [Required(ErrorMessage = "请输入文章标题")]
        [StringLength(150)]
        public string Title { get; set; }

        [DisplayName("文章作者")]
        [Required(ErrorMessage = "请输入文章作者")]
        [StringLength(12)]
        public string About { get; set; }


    }
}