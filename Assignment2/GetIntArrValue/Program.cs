using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetIntArrValue
{
    class Program
    {
        static void Main(string[] args)
        {
            //随机初始化一个数组作为测试用例
            int[] a = new int[100];
            for (int i = 0; i < a.Length; ++i)
            { 
                a[i] = 12; 
            }

            int sum = a[0];
            int max = a[0];
            int min = a[0];

            for (int i = 1; i < a.Length; ++i)
            {
                sum += a[i];
                if (max < a[i]) max = a[i];
                if (min > a[i]) min = a[i];
            }

            Console.WriteLine( "最大值:" + max );
            Console.WriteLine( "最小值:" + min );
            Console.WriteLine( "总和:" + sum );
            Console.WriteLine( "平均值:" + ((double) sum/a.Length) );

            Console.ReadKey();
            
        }
    }
}
