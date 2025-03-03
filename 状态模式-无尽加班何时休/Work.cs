using System;
using System.Collections.Generic;
using System.Text;

namespace 状态模式_无尽加班何时休
{
    public class Work
    {
        private State state;
        public Work()
        {
            this.state = new ForenoonState();   //初始化工作状态(上午九点上班)
        }
        private int hour;
        private bool taskFinished;

        /// <summary>
        /// 钟点(状态切换依据)
        /// </summary>
        public int Hour
        {
            get { return this.hour; }
            set { this.hour = value; }
        }

        /// <summary>
        /// 任务状态(是否完成)
        /// </summary>
        public bool TaskFinished
        {
            get { return this.taskFinished; }
            set { this.taskFinished = value; }
        }

        /// <summary>
        /// 状态切换
        /// </summary>
        /// <param name="state"></param>
        public void SetState(State state)
        {
            this.state = state;
        }

        public void WriteProgram()
        {
            state.WorkProgram(this);
        }
    }
}
