using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        BigInteger centuries = BigInteger.Parse(Console.ReadLine());

        BigInteger years = centuries * 100;
        BigInteger days = (int) ((double)centuries * 36524.22);
        BigInteger hours = days * 24;
        BigInteger minutes = hours * 60;
        BigInteger seconds = minutes * 60;
        BigInteger milliseconds = seconds * 1000;
        BigInteger microseconds = milliseconds * 1000;
        BigInteger nanoseconds = microseconds * 1000;

        Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = { seconds} seconds = { milliseconds} milliseconds = { microseconds} microseconds = { nanoseconds} nanoseconds");
    }
}