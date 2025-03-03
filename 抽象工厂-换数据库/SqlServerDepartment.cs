using System;
using System.Collections.Generic;
using System.Text;

namespace 抽象工厂_换数据库
{
    class SqlServerDepartment : IDepartment
    {
        public void Insert(Department department)
        {
            Console.WriteLine("在Sql Server中给Department表添加一条记录");
        }

        public Department GetDepartment(int id)
        {
            Console.WriteLine("在Sql Server中根据ID得到Department表一条记录");
            return null;
        }
    }
}
