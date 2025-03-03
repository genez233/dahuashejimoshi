using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace 状态模式_无尽加班何时休
{
    public abstract class State
    {
        public abstract void WorkProgram(Work w);
    }
}
