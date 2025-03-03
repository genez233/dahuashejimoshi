using System;
using System.Collections.Generic;
using System.Text;

namespace 状态模式_无尽加班何时休
{
    public class AfternoonState : State
    {
        /// <summary>
        /// 下午工作状态
        /// </summary>
        /// <param name="w"></param>
        public override void WorkProgram(Work w)
        {
            if (w.Hour < 18)
            {
                Console.WriteLine($"当前时间：{w.Hour} 下午状态不错 继续努力");
            }
            else
            {
                w.SetState(new EveningState());
                w.WriteProgram();
            }
        }
    }
}
