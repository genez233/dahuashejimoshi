using System;
using System.Collections.Generic;
using System.Text;

namespace 抽象工厂_换数据库
{
    interface IUser
    {
        void Insert(User user);
        User GetUser(int id);
    }
}
