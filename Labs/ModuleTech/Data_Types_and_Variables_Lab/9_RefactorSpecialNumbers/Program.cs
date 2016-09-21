using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_RefactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sumOfDigits = 0;
            int number = 0;
            bool trueOrFalse;
            for (int i = 1; i <= num; i++)
            {
                number = i;
                while (number > 0)
                {
                    sumOfDigits += number % 10;
                    number = number / 10;
                }
                trueOrFalse = (sumOfDigits == 5) || (sumOfDigits == 7) || (sumOfDigits == 11);
                Console.WriteLine($"{i} -> {trueOrFalse}");
                sumOfDigits = 0;
            }
        }
    }
}
