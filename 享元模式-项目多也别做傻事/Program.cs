using System;

namespace 享元模式_项目多也别做傻事
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            WebSiteFactory factory = new WebSiteFactory();

            WebSite site1 = factory.GetWebSiteCategory("产品展示");
            site1.Use(new User("小菜"));

            WebSite site2 = factory.GetWebSiteCategory("产品展示");
            site2.Use(new User("大鸟"));

            WebSite site3 = factory.GetWebSiteCategory("博客");
            site3.Use(new User("何三岁"));

            WebSite site4 = factory.GetWebSiteCategory("博客");
            site4.Use(new User("陈Ⅳ"));

            Console.WriteLine($"网站实例化总数：{factory.GetWebSiteCount()}");
            Console.Read();
        }
    }
}
