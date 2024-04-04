using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial2Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = 1;
            var b = 2;
            var c = 3;

            byte number = 1000;
            Console.WriteLine(number);
            var sum = (float)a / (float)b;

            // Console.WriteLine(sum);

            var sum2 = (a + b) * c;

            // Console.WriteLine(sum2);
            // Console.WriteLine(!(a != b));
            Console.WriteLine(c > b && c == a);
        }
    }
}
