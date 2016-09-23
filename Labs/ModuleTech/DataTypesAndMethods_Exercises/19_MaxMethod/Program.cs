using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_MaxMethod
{
    class Program
    {
        static void GetMax(int a, int b)
        {
            Console.WriteLine(Math.Max(a, b));
        }

        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int a = 0;
            int b = 0;
            if (num1 >= num2)
            {
                a = num1;
                b = num3;
            }
            else
            {
                a = num2;
                b = num3;
            }
            GetMax(a, b);
        }
    }
}
