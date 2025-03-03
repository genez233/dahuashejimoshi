using System;
using System.Collections.Generic;
using System.Text;

namespace 组合模式_公司管理系统
{
    /// <summary>
    /// 一区科技公司（具体公司类--实现接口 树枝节点）
    /// </summary>
    public class ConcreteCompany : Company
    {
        private List<Company> children = new List<Company>();
        public ConcreteCompany(string name) : base(name)
        {
        }

        public override void Add(Company c)
        {
            children.Add(c);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name);
            foreach (var item in children)
            {
                item.Display(depth + 2);
            }
        }

        public override void LineOfDuty()
        {
            foreach (var item in children)
            {
                item.LineOfDuty();
            }
        }

        public override void Remove(Company c)
        {
            children.Remove(c);
        }
    }
}
