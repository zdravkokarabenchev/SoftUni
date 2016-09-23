using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_NumbersInReversedOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            PrintTheNumberInAReversedOrder(number);
        }

        private static void PrintTheNumberInAReversedOrder(string number)
        {
            int position = number.Length - 1;
            while (position >= 0)
            {
                Console.Write(number[position]);
                position -= 1;
            }
        }
    }
}
