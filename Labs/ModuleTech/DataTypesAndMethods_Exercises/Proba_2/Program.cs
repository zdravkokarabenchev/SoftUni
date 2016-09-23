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
            string strProba = "";
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
                        strProba += k;
                    }
                    else
                    {
                        strProba += ", " + k;
                    }
                    counter++;
                }
            }
            Console.WriteLine(strProba);
        }
    }
}
