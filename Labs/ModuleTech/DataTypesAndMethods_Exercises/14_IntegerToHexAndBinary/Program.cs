using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());

        string hex = Convert.ToString(number, 16);
        string binary = Convert.ToString(number, 2);
        Console.WriteLine(hex.ToUpper());
        Console.WriteLine(binary.ToUpper());
    }
}