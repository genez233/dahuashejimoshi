using System;
using System.Collections.Generic;
using System.Text;

namespace 状态模式_无尽加班何时休
{
    /// <summary>
    /// 下班状态
    /// </summary>
    public class RestState : State
    {
        public override void WorkProgram(Work w)
        {
            Console.WriteLine($"当前时间：{w.Hour} 下班休息 关机走人");
        }
    }
}
