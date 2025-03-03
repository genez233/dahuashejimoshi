using System;
using System.Collections.Generic;
using System.Text;

namespace 组合模式_公司管理系统
{
    /// <summary>
    /// 部门
    /// </summary>
    public class Departments
    {
        /// <summary>
        /// 人力资源部
        /// </summary>
        public class HRDepartment : Company
        {
            public HRDepartment(string name) : base(name)
            {

            }
            public override void Add(Company c)
            {
                throw new NotImplementedException();
            }

            public override void Display(int depth)
            {
                Console.WriteLine(new String('-', depth) + name);
            }

            public override void LineOfDuty()
            {
                Console.WriteLine($"{name}　员工招聘培训管理");
            }

            public override void Remove(Company c)
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// 财务部
        /// </summary>
        public class FinanceDepartment : Company
        {
            public FinanceDepartment(string name) : base(name)
            {

            }
            public override void Add(Company c)
            {
                throw new NotImplementedException();
            }

            public override void Display(int depth)
            {
                Console.WriteLine(new String('-', depth) + name);
            }

            public override void LineOfDuty()
            {
                Console.WriteLine($"{name}　公司财务收支管理");
            }

            public override void Remove(Company c)
            {
                throw new NotImplementedException();
            }
        }
    }
}
