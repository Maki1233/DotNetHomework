using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[3,4] { { 1, 2, 3, 4 }, { 5, 1, 2, 3 }, { 9, 5, 1, 2 } };
            Console.WriteLine(IsTargrtMatrix(arr));
            Console.ReadKey();
        }
        public static bool IsTargrtMatrix(int[,] arr)
        {
            int x = arr.GetLength(0);
            int y = arr.GetLength(1);
            for(int i= 0; i < x - 1; ++i)
            {
                for(int j = 0; j < y - 1; ++j)
                {
                    if (arr[i,j] != arr[i + 1,j + 1])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
