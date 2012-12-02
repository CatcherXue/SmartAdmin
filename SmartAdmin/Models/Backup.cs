using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Smart.Admin.Models
{
    /// <summary>
    /// 网站备份实体
    /// </summary>
    public class Backup
    {
        [Key]
        [DisplayName("备份名称")]
        [StringLength(50)]
        [Required(ErrorMessage = "请输入备份名称")]
        public string Name { get; set; }

        [DisplayName("备份日期")]
        [DataType(DataType.DateTime)]
        [Required(ErrorMessage = "请输入备份日期")]
        public DateTime BackupDate { get; set; }

        [DisplayName("存储路径")]
        [DataType(DataType.Url)]
        public string SavePath { get; set; }

        [DisplayName("文件大小")]
        public int Size { get; set; }

        [DisplayName("描述信息")]
        [StringLength(128)]
        public string Description { get; set; }
    }
}