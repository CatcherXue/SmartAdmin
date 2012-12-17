using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Smart.Admin.Models
{
    /// <summary>
    /// 初始化数据
    /// </summary>
    public class InitData : DropCreateDatabaseIfModelChanges<SmartAdminDB>
    {
        protected override void Seed(SmartAdminDB context)
        {
            /*
             * 初始化用户信息数据
             */
            new List<User>
            {
                new User(){ CurrentIPAddress="127.0.0.1", EmailAddress="", EndLoginDate=DateTime.Now, MutileOnLine = false, Nick="超级管理员", OnLine = false, Password="admin", RegisterDate=DateTime.Now, UserName="admin", UserRole="超级管理员"}
            }.ForEach(m => context.Users.Add(m));

            /*
             * 初始化文章类目数据
             */
            var menu = new List<ArticleCat>
            {
                new ArticleCat(){ Cid=0, IsParent = true, Name="默认分类", Order=0, ParentCid=0, Status="normal"}
            };
        }
    }
}