using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetPrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[] arr = new bool[100];
            int prime = 2;
            while (prime < 100)
            {
                for (int i = 1; i < 100; ++i)
                {
                    if ((i + 1) % prime == 0 && prime < i + 1)
                    {
                        arr[i] = true;
                    }
                }
                ++prime;
            }
            for(int i = 1; i < 100; ++i)
            {
                if (arr[i] == false)
                {
                    Console.Write((i + 1) + " ");
                }
            }
            Console.ReadKey();
        }
    }
}
