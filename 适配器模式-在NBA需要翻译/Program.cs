using System;

namespace 适配器模式_在NBA需要翻译
{
    class Program
    {
        static void Main(string[] args)
        {
            Player forward = new Forwards("乔治");
            forward.Attack();
            forward.Defense();

            Player center = new Translator("姚明");
            center.Attack();
            center.Defense();

            Console.Read();
        }
    }
}
