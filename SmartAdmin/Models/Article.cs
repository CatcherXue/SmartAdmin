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
    /// 编号,标题,发布时间,来源,来源链接,作者,摘要,内容,关键字,文章分类
    /// </summary>
    public class Article
    {
        /// <summary>
        /// 文章编号
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        /// <summary>
        /// 文章标题
        /// </summary>
        [StringLength(150)]
        public string ArticleTitle { get; set; }

        /// <summary>
        /// 发布时间
        /// </summary>
        public DateTime PublishTime { get; set; }

        /// <summary>
        /// 来源名称
        /// </summary>
        [StringLength(50)]
        public string SourceName { get; set; }

        /// <summary>
        /// 来源链接
        /// </summary>
        [StringLength(150)]
        public string SourceLink { get; set; }

        /// <summary>
        /// 文章作者
        /// </summary>
        [StringLength(50)]
        public string About { get; set; }

        /// <summary>
        /// 摘要描述
        /// </summary>
        [StringLength(512)]
        public string Summary { get; set; }

        /// <summary>
        /// 关键字
        /// </summary>
        [StringLength(80)]
        public string Keywords { get; set; }

        /// <summary>
        /// 正文内容
        /// </summary>
        [StringLength(8000)]
        public string Content { get; set; }

        /// <summary>
        /// 文章分类
        /// </summary>
        public int ArticleCat { get; set; }
    }
}