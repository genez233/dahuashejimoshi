using System;
using System.Collections.Generic;
using System.Text;

namespace 桥接模式_手机软件何时统一
{
    /// <summary>
    /// 手机品牌
    /// </summary>
    public abstract class MobilePhoneBrand
    {
        protected MobilePhoneSoft soft;

        public void SetupSoft(MobilePhoneSoft soft)
        {
            this.soft = soft;
        }

        public abstract void Run();
    }
}
