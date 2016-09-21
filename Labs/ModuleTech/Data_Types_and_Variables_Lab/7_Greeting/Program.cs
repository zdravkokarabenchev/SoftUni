using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Greeting
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string surName = Console.ReadLine();
            string age = Console.ReadLine();

            Console.WriteLine($"Hello, {name} {surName}. You are {age} years old.");
        }
    }
}
