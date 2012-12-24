using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Smart.Admin.Models
{
    /// <summary>
    /// 产品类目
    /// </summary>
    public class ProductsCat
    {
        /// <summary>
        /// 分类编号
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("分类编号")]
        public int Cid { get; set; }

        /// <summary>
        /// 父级分类
        /// </summary>
        [DisplayName("父级分类")]
        public int ParentCid { get; set; }

        /// <summary>
        /// 分类名称
        /// </summary>
        [DisplayName("分类名称")]
        [StringLength(50)]
        public string Name { get; set; }

        /// <summary>
        /// 分类排序
        /// </summary>
        [DisplayName("分类排序")]
        public int Order { get; set; }

        /// <summary>
        /// 是否父类
        /// </summary>
        [DisplayName("是否父类")]
        public bool IsParent { get; set; }

        /// <summary>
        /// 分类状态
        /// normal:正常/deleted:删除
        /// </summary>
        [DisplayName("分类状态")]
        [StringLength(50)]
        public string Status { get; set; }
    }
}