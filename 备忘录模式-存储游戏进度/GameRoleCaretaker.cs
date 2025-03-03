using System;
using System.Collections.Generic;
using System.Text;

namespace 备忘录模式_存储游戏进度
{
    public class GameRoleCaretaker
    {
        private GameMemento memento;
        public GameMemento Memento { get { return memento; } set { memento = value; } }
    }
}
