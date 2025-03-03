using System;

namespace 迭代器模式_上车就买票
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            ConcreteAggregate ca = new ConcreteAggregate();     //公交车，即聚集对象

            ca[0] = "权志龙";
            ca[1] = "太阳";
            ca[2] = "宋旻浩";
            ca[3] = "行旅";
            ca[4] = "公交内部工作人员";
            ca[5] = "小偷";

            Iterator iterator = new ConcreteIterator(ca);   //售票员出场，先看好了上车的是哪些人，即声明迭代器对象
            object item = iterator.First(); //第一个乘客

            while (!iterator.IsDone())
            {
                Console.WriteLine($"{iterator.GetCurrent()}　请买票！");
                iterator.Next();
            }

            Console.Read();
        }
    }
}
