using System;
using System.Collections.Generic;
using System.Text;

namespace 抽象工厂_换数据库
{
    class AccesssUser : IUser
    {
        public void Insert(User user)
        {
            Console.WriteLine("在Accesss中给User表添加一条记录");
        }

        public User GetUser(int id)
        {
            Console.WriteLine("在Accesss中根据ID得到User表一条记录");
            return null;
        }
    }
}
