using System;
using System.Runtime.ConstrainedExecution;

namespace 事件与委托_猫和老鼠
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Cat cat = new Cat("Tom");

            Mouse mouse1 = new Mouse("Jerry");
            Mouse mouse2 = new Mouse("Jack");

            //+= 表示cat.add_CatShout
            cat.CatShout += new Cat.CatShoutEventHandle(mouse1.Run);
            cat.CatShout += new Cat.CatShoutEventHandle(mouse2.Run);

            cat.Shout();

            Console.Read();
        }

        /// <summary>
        /// 猫类
        /// </summary>
        class Cat
        {
            private string name;
            public Cat(string name)
            {
                this.name = name;
            }

            //声明委托CatShoutEventHandle
            public delegate void CatShoutEventHandle(object sender, CatShoutEventArgs args);

            //声明事件CatShout  事件类型是委托CatShoutEventHandle
            public event CatShoutEventHandle CatShout;

            public void Shout()
            {
                Console.WriteLine("喵，我是{0}", name);


                //if (CatShout != null)
                //{
                //    CatShoutEventArgs e = new CatShoutEventArgs();
                //    e.Name = this.name;
                //    CatShout(this, e);
                //}
                CatShoutEventArgs e = new CatShoutEventArgs();
                e.Name = this.name;
                CatShout?.Invoke(this, e);

            }
        }

        //老鼠类
        class Mouse
        {
            private string name;
            public Mouse(string name)
            {
                this.name = name;
            }


            public void Run(object sender, CatShoutEventArgs args)
            {
                Console.WriteLine("猫{1}来了，{0} 快跑！", name, args.Name);
            }
        }

        public class CatShoutEventArgs : EventArgs
        {
            private string name;
            public string Name
            {
                get { return name; }
                set { name = value; }
            }
        }
    }
}
