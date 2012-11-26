asp.net mvc3版本的通用网站管理后台。

功能模块

门户基础模块：

模块名称	控制器		功能描述
1.文章管理	/Article
2.产品管理	/Product
4.图片管理	/Picture
5.附件管理	/Attachment
6.留言管理	/LeaveMessage
7.联系方式	/Contact
8.链接管理	/Link

网站基础模块：
模块名称	控制器		功能描述
1.网站设置	/Configuration	管理网站域名等信息。
2.备份恢复	/Backup		备份恢复数据库。
3.用户管理	/User		网站管理员、职员、会员账户管理。
4.日志管理	/Logger		网站访问日志管理。
5.访客分析	/Analysis	分析网站的访客流量、设置第三方统计代码等。
6.安全设置	/Security	配置数据库、FTP等账号设置，以及网站文件安全扫描等功能。
7.更新维护	/Update		提供建库、升级建库、补丁脚本、安全程序补丁更新维护功能。
8.开放平台	/Interface	提供第三方调用API接口功能，用于第三方采集器连接、自动发布等。

页面地址
xxx.com/Admin/	根地址
Admin/Install	安装向导
Admin/Login	用户登录
Admin/Register	注册用户
Admin/Index	默认后台
Admin/VerificationCode	返回一张验证码图片,字符存放在Session中，键名是VerificationCode,有效域是/admin/*。

默认约定：
1.使用Cookie授权,有效期7天。
2.网站页面编码全部使用utf-8。
3.所有请求的Url需要UrlEncoding。