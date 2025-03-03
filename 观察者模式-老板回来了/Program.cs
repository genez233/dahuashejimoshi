using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;

namespace 观察者模式_老板回来了
{
    class Program
    {
        static void Main(string[] args)
        {
            //前台小姐姐:hby
            Subject hedy = new Boss();

            //看股票的同事
            Observer ts_1 = new StockObserver("Canaban1", hedy);
            Observer ts_2 = new NBAObserver("Canaban2", hedy);

            //hedy记下两位同事
            hedy.Attach(ts_1);
            hedy.Attach(ts_2);

            //老板回来了
            hedy.SubjectState = "老板回来了";

            //通知两位同事
            hedy.Notify();

            Console.Read();
        }

        /// <summary>
        ///  抽象前台秘书接口
        /// </summary>
        interface Subject
        {
            void Attach(Observer observer);
            void Detach(Observer observer);

            void Notify();
            string SubjectState
            {
                get;
                set;
            }
        }

        /// <summary>
        /// 前台秘书类
        /// </summary>
        class Secretary : Subject
        {
            //同事列表
            private IList<Observer> observers = new List<Observer>();
            private string action;

            //增加
            public void Attach(Observer observer)
            {
                observers.Add(observer);
            }

            //减少
            public void Detach (Observer observer)
            {
                observers.Remove(observer);
            }
            //通知
            public void Notify()
            {
                foreach (var item in observers)
                {
                    item.Update();
                }
            }

            //前台状态
            public string SubjectState
            {
                get { return this.action; }
                set { action = value; }
            }
        }


        class Boss : Subject
        {
            private IList<Observer> observers = new List<Observer>();
            private string action;
            public string SubjectState { get { return this.action; } set { action = value; } }

            public void Attach(Observer observer)
            {
                observers.Add(observer);
            }

            public void Detach(Observer observer)
            {
                observers.Remove(observer);
            }

            public void Notify()
            {
                foreach (var item in observers)
                {
                    item.Update();
                }
            }
        }

        /// <summary>
        /// 看股票同事类
        /// </summary>
        class StockObserver : Observer
        {
            /// <summary>
            /// 构造函数
            /// </summary>
            /// <param name="name"></param>
            /// <param name="secretary"></param>
            public StockObserver(string name, Subject secretary) : base(name, secretary)
            {
                
            }

            public override void Update()
            {
                Console.WriteLine("{0} {1} 关闭股票行情，继续工作", secretary.SubjectState, name);
            }
        }

        /// <summary>
        /// 看NBA直播同事类
        /// </summary>
        class NBAObserver : Observer
        {
            /// <summary>
            /// 构造函数
            /// </summary>
            /// <param name="name"></param>
            /// <param name="secretary"></param>
            public NBAObserver(string name, Subject secretary) : base(name, secretary)
            {

            }

            public override void Update()
            {
                Console.WriteLine("{0} {1} 关闭NBA直播，继续工作", secretary.SubjectState, name);
            }
        }

        //抽象的观察者类
        abstract class Observer
        {
            protected string name;
            protected Subject secretary;

            public Observer(string name, Subject secretary)
            {
                this.name = name;
                this.secretary = secretary;
            }

            public abstract void Update();
        }
    }
}
