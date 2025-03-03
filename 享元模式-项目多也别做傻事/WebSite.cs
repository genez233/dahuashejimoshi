using System;
using System.Collections.Generic;
using System.Text;

namespace 享元模式_项目多也别做傻事
{
    /// <summary>
    /// 网站抽象类
    /// </summary>
    public abstract class WebSite
    {
        public abstract void Use(User user);
    }
}
