using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Smart.Admin.Models
{
    /// <summary>
    /// SmartAdmin管理平台数据库
    /// </summary>
    public class SmartAdminDB : DbContext
    {
        /// <summary>
        /// 用户信息表
        /// </summary>
        public DbSet<User> Users { get; set; }

        /// <summary>
        /// 网站配置信息表
        /// </summary>
        public DbSet<Configuration> Configurations { get; set; }

        /// <summary>
        /// 数据备份信息表
        /// </summary>
        public DbSet<Backup> Backups { get; set; }

        /// <summary>
        /// 文章信息表
        /// </summary>
        public DbSet<Article> Articles { get; set; }

        /// <summary>
        /// 文章类目表
        /// </summary>
        public DbSet<ArticleCat> ArticleCats { get; set; }

        /// <summary>
        /// 开放平台接口信息表
        /// </summary>
        //public DbSet<Interface> Interfaces { get; set; }

        /// <summary>
        /// 日志记录器信息表
        /// </summary>
        //public DbSet<Logger> Loggers { get; set; }

        /// <summary>
        /// 安全配置信息表
        /// </summary>
        //public DbSet<Security> Securitys { get; set; }

        /// <summary>
        /// 系统配置信息表
        /// </summary>
        //public DbSet<System> Systems { get; set; }


        /// <summary>
        /// 升级信息表
        /// </summary>
        //public DbSet<Update> Updates { get; set; }
    }
}