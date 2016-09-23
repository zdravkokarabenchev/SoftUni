using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        char ch = char.Parse(Console.ReadLine());

        if (ch>= 48 && ch <= 57)
        {
            Console.WriteLine("digit");
        }
        else if ((ch== 'a' || ch== 'o' || ch == 'u' || ch == 'e' || ch == 'i' || ch == 'y') || (ch == 'A' || ch == 'O' || ch == 'U' || ch == 'E' || ch == 'I' || ch == 'Y'))
        {
            Console.WriteLine("vowel");
        }
        else
        {
            Console.WriteLine("other");
        }
    }
}

