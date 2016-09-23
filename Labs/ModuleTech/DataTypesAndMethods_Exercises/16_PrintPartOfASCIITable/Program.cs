using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        int firstCharIndex = int.Parse(Console.ReadLine());
        int lastCharIndex = int.Parse(Console.ReadLine());
        for (int i = firstCharIndex; i <= lastCharIndex; i++)
        {
            var ch = Convert.ToChar(i);
            Console.Write(ch + " ");
        }


        //char firstChar = char.Parse(Console.ReadLine());
        //char lastChar = char.Parse(Console.ReadLine());
        //for (int i = firstChar; i <= lastChar; i++)
        //{
        //    Console.Write(i+" ");
        //}
    }
}