using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car hyundai = new Car("Hyundai", 600, "Black");
            hyundai.Drive();
            Car Suzuki = new Car("Suzuki");
            Suzuki.Drive();

            Car car = new Car();
            //
            car.Description();

            Console.WriteLine("Options \n 1 Stop Car, 2 Car Description");
            var input = Console.ReadLine();

            if(input != null)
            {
                if(input == "1")
                {
                    hyundai.Stop();
                }
                if(input == "2")
                {
                    hyundai.Description();
                }
            }
           


        }
    }
}
