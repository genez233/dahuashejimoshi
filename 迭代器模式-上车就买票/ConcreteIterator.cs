using System;
using System.Collections.Generic;
using System.Text;

namespace 迭代器模式_上车就买票
{
    /// <summary>
    /// 具体迭代器类  继承Iterator
    /// </summary>
    public class ConcreteIterator : Iterator
    {
        private ConcreteAggregate aggregate;
        private int currIndex = 0;

        public ConcreteIterator(ConcreteAggregate aggregate)
        {
            this.aggregate = aggregate;
        }
        public override object First()
        {
            return aggregate[0];
        }

        public override object GetCurrent()
        {
            return aggregate[currIndex];
        }

        public override bool IsDone()
        {
            return currIndex >= aggregate.Count;
        }

        public override object Next()
        {
            object ret = null;
            currIndex++;
            if (currIndex < aggregate.Count)
            {
                ret = aggregate[currIndex];
            }
            return ret;
        }
    }
}
