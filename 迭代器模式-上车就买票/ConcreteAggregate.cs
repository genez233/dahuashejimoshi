using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace 迭代器模式_上车就买票
{
    /// <summary>
    /// 具体聚集类  继承Aggregate
    /// </summary>
    public class ConcreteAggregate : Aggregate
    {
        //声明泛型变量，用于放聚合对象，用ArrayList也可以
        private IList<object> list = new List<object>();
        public override Iterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }

        //返回聚集总个数
        public int Count { get { return this.list.Count; } }

        /// <summary>
        /// 索引器
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public object this[int index]
        {
            get { return list[index]; }
            set { list.Insert(index, value); }
        }
    }
}
