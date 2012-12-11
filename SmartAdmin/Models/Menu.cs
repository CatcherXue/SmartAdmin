using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Smart.Admin.Models
{
    /// <summary>
    /// 菜单实体类定义
    /// </summary>
    public class Menu
    {
        /// <summary>
        /// 菜单编号
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        /// <summary>
        /// 菜单名称
        /// </summary>
        [StringLength(20)]
        public string MenuName { get; set; }

        /// <summary>
        /// 菜单地址
        /// </summary>
        [StringLength(50)]
        public string MenuLink { get; set; }

        /// <summary>
        /// 菜单图标
        /// </summary>
        [StringLength(50)]
        public string MenuIcon { get; set; }

        /// <summary>
        /// 菜单描述
        /// </summary>
        [StringLength(50)]
        public string Description { get; set; }

        /// <summary>
        /// 父级菜单
        /// </summary>
        public int ParentID { get; set; }

        /// <summary>
        /// 是否一级菜单
        /// </summary>
        public bool IsParent { get; set; }

        /// <summary>
        /// 菜单状态
        /// normal:正常/deleted:删除
        /// </summary>
        [StringLength(50)]
        public string Status { get; set; }
    }
}