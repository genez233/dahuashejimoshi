using System;

namespace 桥接模式_手机软件何时统一
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            MobilePhoneBrand phone;

            phone = new ConcreteBrand.Honor();
            phone.SetupSoft(new ConcreteSoft.AddressBook());
            phone.Run();

            phone.SetupSoft(new ConcreteSoft.HunDouLuo());
            phone.Run();

            phone = new ConcreteBrand.Apple();
            phone.SetupSoft(new ConcreteSoft.AddressBook());
            phone.Run();

            phone.SetupSoft(new ConcreteSoft.HunDouLuo());
            phone.Run();



            Console.Read();
        }
    }
}
