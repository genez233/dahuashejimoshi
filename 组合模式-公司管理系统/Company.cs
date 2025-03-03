using System;
using System.Collections.Generic;
using System.Text;

namespace 组合模式_公司管理系统
{
    /// <summary>
    /// 公司类（抽象类或接口）
    /// </summary>
    public abstract class Company
    {
        protected string name;
        public Company(string name)
        {
            this.name = name;
        }

        public abstract void Add(Company c);//添加
        public abstract void Remove(Company c);//移除
        public abstract void Display(int depth);//显示
        public abstract void LineOfDuty();//履行职责
    }
}
