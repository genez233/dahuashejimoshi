using System;
using System.Collections.Generic;
using System.Text;

namespace 适配器模式_在NBA需要翻译
{
    /// <summary>
    /// 中锋
    /// </summary>
    public class Center : Player
    {
        public Center(string name) : base(name)
        {

        }
        public override void Attack()
        {
            Console.WriteLine($"中锋{name} 进攻");
        }

        public override void Defense()
        {
            Console.WriteLine($"中锋{name} 防守");
        }
    }
}
