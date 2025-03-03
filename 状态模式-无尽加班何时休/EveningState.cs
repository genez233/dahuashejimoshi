using System;
using System.Collections.Generic;
using System.Text;

namespace 状态模式_无尽加班何时休
{
    public class EveningState : State
    {
        /// <summary>
        /// 加班状态
        /// </summary>
        /// <param name="w"></param>
        public override void WorkProgram(Work w)
        {
            if (w.TaskFinished)
            {
                w.SetState(new RestState());
                w.WriteProgram();
            }
            else
            {
                w.SetState(new SleepingState());
                w.WriteProgram();
            }
        }
    }
}
