using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Smart.Admin.Models
{
    /// <summary>
    /// 产品实体
    /// </summary>
    public class Products
    {
        /// <summary>
        /// 编号
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        /// <summary>
        /// 产品名称
        /// </summary>
        [StringLength(150)]
        public string ProductsName { get; set; }

        /// <summary>
        /// 发布时间
        /// </summary>
        public DateTime PublishTime { get; set; }

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
        /// 产品图片
        /// </summary>
        [StringLength(1024)]
        public string ProductsImage { get; set; }

        /// <summary>
        /// 产品介绍
        /// </summary>
        [StringLength(8000)]
        public string ProductsContent { get; set; }

        /// <summary>
        /// 产品分类
        /// </summary>
        public int ProductsCat { get; set; }
    }
}