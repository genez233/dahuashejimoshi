using System;
using System.Collections.Generic;
using System.Text;

namespace 迭代器模式_上车就买票
{
    /// <summary>
    /// 聚集抽象类
    /// </summary>
    public abstract class Aggregate
    {
        public abstract Iterator CreateIterator();  //创建迭代器
    }
}
