using System;
using System.Collections.Generic;
using System.Text;

namespace 状态模式_无尽加班何时休
{
    public class NoonState : State
    {
        /// <summary>
        /// 午休状态
        /// </summary>
        /// <param name="w"></param>
        public override void WorkProgram(Work w)
        {
            if (w.Hour < 14)
            {
                Console.WriteLine($"当前时间：{w.Hour} 饿了 困了 要午休");
            }
            else
            {
                w.SetState(new AfternoonState());
                w.WriteProgram();
            }
        }
    }
}
