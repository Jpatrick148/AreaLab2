using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber2
{
    class Program
    {
        static void Main(string[] args)
        {
            string lenght, width, height, check;
            double l, w, h, area, peri, vol;


            do
            {
                Console.WriteLine("Please enter length width and height. (In that order)");
                lenght = Console.ReadLine();
                width = Console.ReadLine();
                height = Console.ReadLine();
                l = Double.Parse(lenght);
                w = Double.Parse(width);
                h = Double.Parse(height);

                area = l * w;
                peri = l * 2 + w * 2;
                vol = l * w * h;

                Console.WriteLine("The Area is " + area);
                Console.WriteLine("The Perimeter is " + peri);
                Console.WriteLine("The Volume is " + vol);

                Console.WriteLine("Would you like to run this program again? {Y/N}");
                check = Console.ReadLine().ToLower();

            } while (check == "y");
        }
    }
}
