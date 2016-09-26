using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19__new__TheaThePhotographer
{
    class Program
    {
        static void Main(string[] args)
        {
            int allPictures = int.Parse(Console.ReadLine());
            int filterTimePerPicture = int.Parse(Console.ReadLine());
            double percentageGoodPictures = int.Parse(Console.ReadLine());
            int uploadingTimePerPicture = int.Parse(Console.ReadLine());

            int allPicturesFilter = allPictures * filterTimePerPicture;
            int goodPictures = (int)(Math.Ceiling(allPictures * (percentageGoodPictures / 100))) * uploadingTimePerPicture;
            int totalSeconds = allPicturesFilter + goodPictures;

            TimeSpan time = TimeSpan.FromSeconds(totalSeconds);

            string str = time.ToString(@"d\:hh\:mm\:ss");
            Console.WriteLine(str);
        }
    }
}
