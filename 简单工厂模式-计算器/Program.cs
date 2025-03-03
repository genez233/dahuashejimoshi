using System;
using System.Dynamic;
using System.Net;

namespace 简单工厂模式_计算器
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("第一个数：");
            var NumA = Console.ReadLine();
            Console.WriteLine("操作符：");
            var operate = Console.ReadLine();
            Console.WriteLine("第二个数：");
            var NumB = Console.ReadLine();
            try
            {
                Operation oper = OperationFactory.CreateOperation(operate);
                oper.NumA = Convert.ToDouble(NumA);
                oper.NumB = Convert.ToDouble(NumB);
                var result = oper.GetResult();
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }   
        }

        /// <summary>
        /// 实例工厂(根据操作符决定创建的实例)
        /// </summary>
        class OperationFactory
        {
            public static Operation CreateOperation(string operate)
            {
                Operation oper = null;
                switch (operate)
                {
                    case "+":
                        oper = new OperationAdd();
                        break;
                    case "-":
                        oper = new OperationSub();
                        break;
                    case "*":
                        oper = new OperationMul();
                        break;
                    case "/":
                        oper = new OperationDiv();
                        break;
                }
                return oper;
            }
        }

        /// <summary>
        /// 父类
        /// </summary>
        class Operation
        {
            private double _numA = 0;
            private double _numB = 0;

            public double NumA { get { return _numA; } set { this._numA = value; } }
            public double NumB { get { return _numB; } set { this._numB = value; } }

            public virtual double GetResult()
            {
                double result = 0d;
                return result;
            }
        }

        /// <summary>
        /// 加法
        /// </summary>
        class OperationAdd : Operation
        {
            /// <summary>
            /// 重写父类方法
            /// </summary>
            /// <returns></returns>
            public override double GetResult()
            {
                double result = 0;
                result = NumA + NumB;
                return result;
            }
        }

        /// <summary>
        /// 减法
        /// </summary>
        class OperationSub : Operation
        {
            public override double GetResult()
            {
                double result = 0;
                result = NumA - NumB;
                return result;
            }
        }

        /// <summary>
        /// 乘法
        /// </summary>
        class OperationMul : Operation
        {
            public override double GetResult()
            {
                double result = 0;
                result = NumA * NumB;
                return result;
            }
        }

        /// <summary>
        /// 除法
        /// </summary>
        class OperationDiv : Operation
        {
            public override double GetResult()
            {
                double result = 0;
                if (NumB == 0)
                    throw new Exception("除数不能为0。");
                result = NumA / NumB;
                return result;
            }
        }
    }
}
