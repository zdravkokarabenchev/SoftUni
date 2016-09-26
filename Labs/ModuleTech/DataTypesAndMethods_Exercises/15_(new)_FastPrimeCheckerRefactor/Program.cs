using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15__new__FastPrimeCheckerRefactor
{
    class Program
    {
        static void Main(string[] args)
        {
            int rangeNumber = int.Parse(Console.ReadLine());
            for (int num = 2; num <= rangeNumber; num++)
            {
                bool trueOrFalse = true;
                for (int j = 2; j <= Math.Sqrt(num); j++)
                {
                    if (num % j == 0)
                    {
                        trueOrFalse = false;
                        break;
                    }
                }
                Console.WriteLine($"{num} -> {trueOrFalse}");
            }
        }
    }
}
