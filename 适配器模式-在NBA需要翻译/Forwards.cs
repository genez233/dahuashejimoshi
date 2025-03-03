using System;
using System.Collections.Generic;
using System.Text;

namespace 适配器模式_在NBA需要翻译
{
    /// <summary>
    /// 前锋
    /// </summary>
    public class Forwards : Player
    {
        public Forwards(string name) : base(name)
        {

        }
        public override void Attack()
        {
            Console.WriteLine($"前锋{name} 进攻");
        }

        public override void Defense()
        {
            Console.WriteLine($"前锋{name} 防守");
        }
    }
}
