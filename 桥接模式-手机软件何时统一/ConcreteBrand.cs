using System;
using System.Collections.Generic;
using System.Text;

namespace 桥接模式_手机软件何时统一
{
    public class ConcreteBrand
    {
        private string name;
        /// <summary>
        /// 荣耀牌手机
        /// </summary>
        public class Honor : MobilePhoneBrand
        {
            public override void Run()
            {
                soft.Run();
            }
        }

        /// <summary>
        /// 苹果牌手机
        /// </summary>
        public class Apple : MobilePhoneBrand
        {
            public override void Run()
            {
                soft.Run();
            }
        }
    }
}
