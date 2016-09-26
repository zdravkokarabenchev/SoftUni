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
        int distanceInMeters = int.Parse(Console.ReadLine());
        int hours = int.Parse(Console.ReadLine());
        int minutes = int.Parse(Console.ReadLine());
        int seconds = int.Parse(Console.ReadLine());

        float totalSeconds = seconds + (hours * 3600f) + (minutes * 60f);
        float speedInMetersPerSecond = (float)distanceInMeters / totalSeconds;
        float speedInKilometersPerHour = (distanceInMeters / 1000) / (totalSeconds / 3600f);
        float speedInMilesPerHour = (distanceInMeters / 1609f) / (totalSeconds / 3600f);

        Console.WriteLine(speedInMetersPerSecond);
        Console.WriteLine(speedInKilometersPerHour);
        Console.WriteLine(speedInMilesPerHour);
    }
}
