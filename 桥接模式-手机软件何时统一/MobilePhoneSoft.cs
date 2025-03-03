using System;
using System.Collections.Generic;
using System.Text;

namespace 桥接模式_手机软件何时统一
{
    /// <summary>
    /// 手机软件
    /// </summary>
    public abstract class MobilePhoneSoft
    {
        protected string name;
        public abstract void Run();
    }
}
