using System;
using System.Web;

namespace 组合模式_公司管理系统
{
    class Program
    {
        static void Main(string[] args)
        {

            //var s = "&#947;-苯基-&#945;-(三氟甲基)-&#947;-丁内酯&#65292;顺反异构体混合物";
            //Console.WriteLine(HttpUtility.HtmlDecode(s));

            //Console.WriteLine("Hello World!");
            ConcreteCompany root = new ConcreteCompany("广州总公司");
            root.Add(new Departments.HRDepartment("总公司人力资源部"));
            root.Add(new Departments.FinanceDepartment("总公司财务部"));

            ConcreteCompany an1 = new ConcreteCompany("广州一区科技有限公司");
            an1.Add(new Departments.HRDepartment("一区人力资源部"));
            an1.Add(new Departments.FinanceDepartment("一区财务部"));
            root.Add(an1);

            ConcreteCompany nuochi = new ConcreteCompany("广州诺驰有限公司");
            nuochi.Add(new Departments.HRDepartment("诺驰人力资源部"));
            nuochi.Add(new Departments.FinanceDepartment("诺驰财务部"));
            root.Add(nuochi);

            ConcreteCompany banshi = new ConcreteCompany("天河办事处");
            banshi.Add(new Departments.HRDepartment("天河办事处人力资源部"));
            banshi.Add(new Departments.FinanceDepartment("天河办事处财务部"));
            root.Add(banshi);

            Console.WriteLine("公司结构图：");
            root.Display(1);

            Console.WriteLine("职责：");
            root.LineOfDuty();

            Console.Read();
        }
    }
}
