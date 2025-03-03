using System;
using System.Collections.Generic;
using System.Text;

namespace 状态模式_无尽加班何时休
{
    public class SleepingState : State
    {
        public override void WorkProgram(Work w)
        {
            Console.WriteLine($"当前时间：{w.Hour} 太累了，要睡着了");
        }
    }
}
