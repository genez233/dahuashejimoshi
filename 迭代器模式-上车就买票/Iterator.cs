using System;
using System.Collections.Generic;
using System.Text;

namespace 迭代器模式_上车就买票
{
    /// <summary>
    /// 迭代器抽象类
    /// </summary>
    public abstract class Iterator
    {
        public abstract object First();
        public abstract object Next();
        public abstract bool IsDone();
        public abstract object GetCurrent();
    }
}
