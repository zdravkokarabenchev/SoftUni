using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_EnglishNameOfTheLastDigit
{
    class Program
    {
        static void TheEnglishNameOfTheLastDigit(int number)
        {
            int theLastDigit = number % 10;
            if (theLastDigit == 0)
            {
                Console.WriteLine("zero");
            }
            else if (theLastDigit == 1)
            {
                Console.WriteLine("one");
            }
            else if (theLastDigit == 2)
            {
                Console.WriteLine("two");
            }
            else if (theLastDigit == 3)
            {
                Console.WriteLine("three");
            }
            else if (theLastDigit == 4)
            {
                Console.WriteLine("four");
            }
            else if (theLastDigit == 5)
            {
                Console.WriteLine("five");
            }
            else if (theLastDigit == 6)
            {
                Console.WriteLine("six");
            }
            else if (theLastDigit == 7)
            {
                Console.WriteLine("seven");
            }
            else if (theLastDigit == 8)
            {
                Console.WriteLine("eight");
            }
            else if (theLastDigit == 9)
            {
                Console.WriteLine("nine");
            }
        }

        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            TheEnglishNameOfTheLastDigit(number);
        }
    }
}
