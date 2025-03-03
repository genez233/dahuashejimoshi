using System;
using System.Collections.Generic;
using System.Text;

namespace 备忘录模式_存储游戏进度
{
    /// <summary>
    /// 备忘录类（存储游戏状态角色）
    /// </summary>
    public class GameMemento
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="vit">生命力</param>
        /// <param name="atk">攻击力</param>
        /// <param name="def">防御力</param>
        public GameMemento(int vit, int atk, int def)
        {
            vitality = vit;
            attack = atk;
            defense = def;
        }

        private int vitality;
        /// <summary>
        /// 生命力
        /// </summary>
        public int Vitality
        {
            set { this.vitality = value; }
            get { return vitality; }
        }

        private int attack;
        /// <summary>
        /// 攻击力
        /// </summary>
        public int Attack
        {
            set { this.attack = value; }
            get { return attack; }
        }

        private int defense;
        /// <summary>
        /// 防御力
        /// </summary>
        public int Defense
        {
            set { this.defense = value; }
            get { return defense; }
        }
    }
}
