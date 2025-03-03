using System;
using System.Collections.Generic;
using System.Text;

namespace 享元模式_项目多也别做傻事
{
    /// <summary>
    /// 具体网站类
    /// </summary>
    public class ConcreteWebSite : WebSite
    {
        private string name = "";

        public ConcreteWebSite(string name)
        {
            this.name = name;
        }

        public override void Use(User user)
        {
            Console.WriteLine("网站分类：" + name + "　用户：" + user.Name);
        }
    }
}
