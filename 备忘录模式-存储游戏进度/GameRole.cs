using System;
using System.Collections.Generic;
using System.Text;

namespace 备忘录模式_存储游戏进度
{
    public class GameRole
    {
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

        /// <summary>
        /// 角色状态显示
        /// </summary>
        public void Show()
        {
            Console.WriteLine("角色当前状态");
            Console.WriteLine($"　　体　力：{this.vitality}");
            Console.WriteLine($"　　攻击力：{this.attack}");
            Console.WriteLine($"　　防御力：{this.defense}");
            Console.WriteLine();
        }

        /// <summary>
        /// 角色状态初始化
        /// </summary>
        public void InitState()
        {
            this.vitality = 1000;
            this.attack = 150;
            this.defense = 300;
        }

        /// <summary>
        /// 战斗（失败后数据损耗完）
        /// </summary>
        public void Fight()
        {
            this.vitality = 0;
            this.attack = 0;
            this.defense = 0;
        }
 

        /// <summary>
        /// 保存角色状态
        /// </summary>
        /// <returns></returns>
        public GameMemento SaveState()
        {
            return new GameMemento(this.vitality, this.attack, this.defense);
        }

        /// <summary>
        /// 角色状态恢复
        /// </summary>
        /// <param name="memento"></param>
        public void RecoveryState(GameMemento memento)
        {
            this.vitality = memento.Vitality;
            this.attack = memento.Attack;
            this.defense = memento.Defense;
        }
    }
}
