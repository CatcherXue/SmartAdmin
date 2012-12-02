using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Smart.Admin.Models
{
    /// <summary>
    /// 用户信息实体
    /// </summary>
    public class User
    {
        [Key]
        [DisplayName("用户账号")]
        [Required(ErrorMessage = "请输入用户账号")]
        [StringLength(12)]
        public string UserName { get; set; }

        [DisplayName("用户密码")]
        [Required(ErrorMessage = "请输入用户密码")]
        [StringLength(12)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DisplayName("用户昵称")]
        [Required(ErrorMessage = "请输入用户昵称")]
        [StringLength(20)]
        public string Nick { get; set; }

        [DisplayName("用户角色")]
        [Required(ErrorMessage = "请输入用户角色")]
        [StringLength(20)]
        public string UserRole { get; set; }

        [DisplayName("注册时间")]
        [DataType(DataType.DateTime)]
        public DateTime RegisterDate { get; set; }

        [DisplayName("电子邮件")]
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }

        [DisplayName("最后登录")]
        [DataType(DataType.DateTime)]
        public DateTime EndLoginDate { get; set; }

        [DisplayName("是否在线")]
        public bool OnLine { get; set; }

        [DisplayName("多处在线")]
        public bool MutileOnLine { get; set; }

        [DisplayName("当前IP")]
        public string CurrentIPAddress { get; set; }
    }
}