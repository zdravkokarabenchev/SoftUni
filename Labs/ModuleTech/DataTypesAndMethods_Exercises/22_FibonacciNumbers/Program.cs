using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_FibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Fib(n);
        }

        private static void Fib(int n)
        {
            int n1 = 0;
            int n2 = 1;
            int result = 0;
            if (n == 0)
            {
                Console.WriteLine("1");
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    result = n1 + n2;
                    n1 = n2;
                    n2 = result;
                }
                Console.WriteLine(result);
            }
        }
    }
}
