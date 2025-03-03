using System;
using System.Collections.Generic;
using System.Text;

namespace 状态模式_无尽加班何时休
{
    public class ForenoonState : State
    {
        /// <summary>
        /// 早上上班状态
        /// </summary>
        /// <param name="w"></param>
        public override void WorkProgram(Work w)
        {
            if (w.Hour < 12)
            {
                Console.WriteLine($"当前时间：{w.Hour} 上午工作，精神百倍");
            }
            else
            {
                w.SetState(new NoonState());
                w.WriteProgram();
            }
        }
    }
}
