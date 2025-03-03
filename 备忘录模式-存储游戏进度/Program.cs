using System;

namespace 备忘录模式_存储游戏进度
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Console.WriteLine("初始化状态");
            GameRole diaochan = new GameRole();
            diaochan.InitState();
            diaochan.Show();

            //保存进度
            Console.WriteLine("保存进度时状态");
            GameRoleCaretaker caretaker = new GameRoleCaretaker();
            caretaker.Memento = diaochan.SaveState();
            diaochan.Show();

            //战斗
            Console.WriteLine("战斗后状态");
            diaochan.Fight();
            diaochan.Show();

            //恢复之前状态
            Console.WriteLine("恢复之前状态");
            diaochan.RecoveryState(caretaker.Memento);
            diaochan.Show();
            Console.Read();
        }
    }
}
