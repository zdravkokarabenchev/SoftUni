﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        string hex = Console.ReadLine();
        int dec = Convert.ToInt32(hex, 16);
        Console.WriteLine(dec);
    }
}