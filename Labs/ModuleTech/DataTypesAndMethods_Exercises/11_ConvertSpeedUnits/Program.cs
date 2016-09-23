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

        int totalSeconds = seconds + (hours * 3600) + (minutes * 60);
        double speedInMetersPerSecond = (double)distanceInMeters / totalSeconds;
        decimal speedInKilometersPerHour = (distanceInMeters / 1000) / (totalSeconds / 3600m);
        decimal speedInMilesPerHour = (distanceInMeters / 1609m) / (totalSeconds / 3600m);

        Console.WriteLine("{0:f6}", speedInMetersPerSecond);
        Console.WriteLine("{0:f6}", speedInKilometersPerHour);
        Console.WriteLine("{0:f6}", speedInMilesPerHour);
    }
}
////////////// Every number in the output should be precise up to 6 digits AFTER the floating point!!!
// https://softuni.bg/trainings/resources/video/8776/video-screen-20-may-2016-valention-kolev-programming-fundamentals-may-2016
// около 13-та минута решава задачата без да закръгля знаци, без нищо и си му излиза в джъджа!?!?!?!