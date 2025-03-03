using System;
using System.Collections.Generic;
using System.Text;

namespace 桥接模式_手机软件何时统一
{
    /// <summary>
    /// 具体手机软件类
    /// </summary>
    public class ConcreteSoft
    {
        /// <summary>
        /// 魂斗罗
        /// </summary>
        public class HunDouLuo : MobilePhoneSoft
        {
            public override void Run()
            {
                Console.WriteLine("运行手机软件-魂斗罗");
            }
        }

        /// <summary>
        /// 通讯录
        /// </summary>
        public class AddressBook : MobilePhoneSoft
        {
            public override void Run()
            {
                Console.WriteLine("运行手机软件-通讯录");
            }
        }
    }
}
