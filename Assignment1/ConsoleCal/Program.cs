using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, output;
            string op;
            Console.WriteLine("请输入一个数字：");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("请输入第二个数字：");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("请输入操作符：");
            op = Console.ReadLine();

            if (op == "+")
            {
                output = a + b;
            }
            else if (op == "-")
            {
                output = a - b;
            }
            else if (op == "*")
            {
                output = a * b;
            }
            else if (op == "/")
            {
                output = a / b;
            }
            else
            {
                output = -1000000;
            }

            Console.WriteLine("结果为：" + output);
            Console.ReadKey();
        }
    }
}
