using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace 抽象工厂_换数据库
{
    class DataBaseFactory
    {
        private static readonly string db = "SqlServer";
        private static readonly string AssemblyName = "抽象工厂_换数据库";

        //public static IUser CreateUser()
        //{
        //    IUser retuser = null;
        //    switch (db)
        //    {
        //        case "SqlServer":
        //            retuser = new SqlServerUser();
        //            break;
        //        case "Accesss":
        //            retuser = new AccesssUser();
        //            break;
        //    }

        //    return retuser;
        //}

        public static IUser CreateUser()
        {
            string className = AssemblyName + "." + db + "User";

            return (IUser)Assembly.Load(AssemblyName).CreateInstance(className);
        }

        public static IDepartment CreateDepartment()
        {
            string className = AssemblyName + "." + db + "Department";
            return (IDepartment)Assembly.Load(AssemblyName).CreateInstance(className);
        }
    }
}
