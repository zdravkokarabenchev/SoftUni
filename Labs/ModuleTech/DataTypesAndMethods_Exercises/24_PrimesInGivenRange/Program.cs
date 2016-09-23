using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_PrimesInGivenRange
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            PrimeNumbersInRange(n1, n2);
        }

        private static void PrimeNumbersInRange(int n1, int n2)
        {
            string str = "";
            int counter = 0;
            for (int k = n1; k <= n2; k++)
            {
                bool primeOrNot = true;
                if (k == 0 || k == 1)
                {
                    primeOrNot = false;
                }
                else
                {
                    for (long i = 2; i <= Math.Sqrt(k); i++)
                    {
                        if (k % i == 0)
                        {
                            primeOrNot = false;
                        }
                    }
                }
                if (primeOrNot == true)
                {
                    if (counter == 0)
                    {
                        str += k;
                    }
                    else
                    {
                        str += ", " + k;
                    }
                    counter++;
                }
            }
            Console.WriteLine(str);
        }
    }
}
