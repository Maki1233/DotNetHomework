using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetPrimeFactor
{
    class Program
    {
        static void Main(string[] args)
        {
            int data;
            int primeFactor = 2;

            Console.WriteLine("请输入需要求解因子的数据：");
            data = Convert.ToInt16( Console.ReadLine());

            Console.WriteLine("结果是：");
            for (int i = data ; primeFactor <= i; ++primeFactor)
            {
                while (data % primeFactor == 0)
                {
                    Console.Write(primeFactor + " ");
                    data = data / primeFactor;
                }
            }
            Console.ReadKey();
        }
    }
}
