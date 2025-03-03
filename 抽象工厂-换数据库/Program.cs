using System;
using System.Runtime.ConstrainedExecution;
using System.Reflection;

namespace 抽象工厂_换数据库
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            IUser db = DataBaseFactory.CreateUser();
            db.Insert(user);
            db.GetUser(1);
            Console.Read();
            //Console.WriteLine("Hello World!");
        }
    }
}
