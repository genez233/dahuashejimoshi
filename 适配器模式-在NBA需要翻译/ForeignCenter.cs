using System;
using System.Collections.Generic;
using System.Text;

namespace 适配器模式_在NBA需要翻译
{
    /// <summary>
    /// 外籍中锋
    /// </summary>
    public class ForeignCenter
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public void 进攻()
        {
            Console.WriteLine($"外籍中锋{Name} 进攻");
        }

        public void 防守()
        {
            Console.WriteLine($"外籍中锋{Name} 防守");
        }
    }
}
