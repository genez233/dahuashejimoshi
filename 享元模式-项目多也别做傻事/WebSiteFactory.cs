using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace 享元模式_项目多也别做傻事
{
    /// <summary>
    /// 网站工厂类
    /// </summary>
    public class WebSiteFactory
    {
        private Hashtable flyweights = new Hashtable();

        /// <summary>
        /// 获取网站分类
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public WebSite GetWebSiteCategory(string key)
        {
            if (!flyweights.ContainsKey(key))   //判断是否存在这个对象，有：返回  没有：实例化
            {
                flyweights.Add(key, new ConcreteWebSite(key));
            }
            return (WebSite)flyweights[key];
        }

        /// <summary>
        /// 获取网站分类总数
        /// </summary>
        /// <returns></returns>
        public int GetWebSiteCount()
        {
            return flyweights.Count;
        }


    }
}
