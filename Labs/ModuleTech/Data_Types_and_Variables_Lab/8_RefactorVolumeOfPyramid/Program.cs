using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_RefactorVolumeOfPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Length: ");
            double length = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            double higth = double.Parse(Console.ReadLine());
            double volumeOfThePrism = (length * width * higth) / 3;
            Console.WriteLine("Pyramid Volume: {0:F2}", volumeOfThePrism);
        }
    }
}
