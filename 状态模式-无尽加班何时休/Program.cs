using System;
using System.Collections;

namespace 状态模式_无尽加班何时休
{
    class Program
    {
        static void Main(string[] args)
        {
            Work work = new Work();
            work.Hour = 9;
            work.WriteProgram();

            work.Hour = 10;
            work.WriteProgram();

            work.Hour = 11;
            work.WriteProgram();

            work.Hour = 12;
            work.WriteProgram();

            work.Hour = 13;
            work.WriteProgram();

            work.Hour = 14;
            work.WriteProgram();

            work.Hour = 15;
            work.WriteProgram();

            work.Hour = 18;
            work.TaskFinished = true;
            work.WriteProgram();


            work.Hour = 19;
            work.WriteProgram();

            work.Hour = 20;
            work.WriteProgram();
            Console.Read();
        }
    }
}
