using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19__new__TheaThePhotographer
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            for (int i = n1; i <= n2; i++)
            {
                char code = (char)i;
                Console.Write(code);
                if (i<n2)
                {
                    Console.Write(" ");
                }
            }
        }
    }
}
