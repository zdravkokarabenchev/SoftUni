using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_PrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            IsPrime(n);
        }

        private static void IsPrime(long n)
        {
            bool primeOrNot = true;
            if (n==0 || n==1)
            {
                primeOrNot = false;
            }
            else
            {
                for (long i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                    {
                        primeOrNot = false;
                    }
                }
            }            
            Console.WriteLine(primeOrNot);
        }
    }
}
