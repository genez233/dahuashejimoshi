using System;
using System.Collections.Generic;
using System.Text;

namespace 适配器模式_在NBA需要翻译
{
    /// <summary>
    /// NBA运动员
    /// </summary>
    public abstract class Player
    {
        protected string name;
        public Player(string name)
        {
            this.name = name;
        }
        /// <summary>
        /// 进攻
        /// </summary>
        public abstract void Attack();
        /// <summary>
        /// 防守
        /// </summary>
        public abstract void Defense();
    }
}
