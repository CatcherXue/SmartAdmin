using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Smart.Admin.Models
{
    /// <summary>
    /// 网站基础信息实体
    /// </summary>
    public class Configuration
    {
        [Key]
        [DataType(DataType.Url)]
        [DisplayName("网站域名")]
        [Required(ErrorMessage = "请输入网站域名")]
        [StringLength(255)]
        public string Domain { get; set; }

        [DisplayName("网站名称")]
        [Required(ErrorMessage = "请输入网站名称")]
        [StringLength(75)]
        public string SiteName { get; set; }
        
        [DataType(DataType.Date)]
        [DisplayName("注册时间")]
        public DateTime RegisterDate { get; set; }

        [DisplayName("备案号码")]
        [StringLength(20)]
        public string ICPNumber { get; set; }

        [DisplayName("网站描述")]
        [StringLength(255)]
        public string Description { get; set; }

        [DisplayName("网站关键字")]
        [StringLength(255)]
        public string Keywords { get; set; }

        [DisplayName("公司名称")]
        [StringLength(75)]
        public string CompanyName { get; set; }

        [DisplayName("注册商标")]
        [DataType(DataType.ImageUrl)]
        public string Trademark { get; set; }

        [DisplayName("营业执照")]
        [DataType(DataType.ImageUrl)]
        public string BusinessLicense { get; set; }

        [DisplayName("法定代表人")]
        [StringLength(30)]
        public string Quorum { get; set; }

        [DisplayName("网站负责人")]
        [StringLength(30)]
        public string SiteAdmin { get; set; }

        [DisplayName("公司地址")]
        [StringLength(512)]
        public string CompanyAddress { get; set; }

        [DisplayName("版权信息")]
        [StringLength(1024)]
        public string CopyRight { get; set; }

        [DisplayName("网站图标")]
        [DataType(DataType.ImageUrl)]
        public string SiteLogo { get; set; }
    }
}