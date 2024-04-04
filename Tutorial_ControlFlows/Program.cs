using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_ControlFlows
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Write a program and ask the user to enter the width and height of an image. Then tell if the image is landscape or portrait.*/

            int width, height;
            Console.WriteLine("Enter Width and Height respectively, to check it's landscape");
            var inputW = Console.ReadLine();
            var inputH = Console.ReadLine();

            width = Convert.ToInt32(inputW);
            height = Convert.ToInt32(inputH);

            if(width > height)
            {
                Console.WriteLine("Image is Landscape");
            }
            else if(height > width)
            {
                Console.WriteLine("Image is Portrait");
            }
            else
            {
                Console.WriteLine("The image is a square ");
            }

        }
    }
}
