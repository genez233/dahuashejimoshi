using System;
using System.Collections.Generic;
using System.Text;

namespace 适配器模式_在NBA需要翻译
{
    /// <summary>
    /// 翻译者（适配器）
    /// </summary>
    public class Translator : Player
    {
        private ForeignCenter wjzf = new ForeignCenter();
        public Translator(string name) : base(name)
        {
            wjzf.Name = name;
        }

        public override void Attack()
        {
            wjzf.进攻();
        }

        public override void Defense()
        {
            wjzf.防守();
        }
    }
}
