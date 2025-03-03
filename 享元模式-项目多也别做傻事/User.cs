using System;
using System.Collections.Generic;
using System.Text;

namespace 享元模式_项目多也别做傻事
{
    /// <summary>
    /// 用户类
    /// </summary>
    public class User
    {
        public User(string name)
        {
            this.name = name;
        }
        private string name { get; set; }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
