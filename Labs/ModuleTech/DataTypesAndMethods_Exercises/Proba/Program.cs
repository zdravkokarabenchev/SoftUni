﻿using System;
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
            string str = Console.ReadLine();
            for (int i = str.Length-1; i >= 0; i--)
            {
                char letter = str[i];
                Console.Write(letter);
            }
        }
    }
}
