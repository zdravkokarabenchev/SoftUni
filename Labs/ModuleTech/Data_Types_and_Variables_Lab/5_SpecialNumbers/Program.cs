using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                int digit = 0;
                int num = i;
                while (num > 0)
                {
                    digit += (num % 10);
                    num = num / 10;
                }
                //if (digit == 5 || digit == 7 || digit == 11)
                //{
                //    Console.WriteLine($"{i} -> True");
                //}
                //else
                //{
                //    Console.WriteLine($"{i} -> False");
                //}
                bool result = (digit == 5 || digit == 7 || digit == 11);
                Console.WriteLine($"{i} -> {result}");
            }
        }
    }
}
