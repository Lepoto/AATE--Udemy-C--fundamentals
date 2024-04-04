using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tutorial3_Class.Math;

namespace Tutorial3_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.Name = "Alfred";
            person.Surname = "Masekwameng";

            person.Introduce();

            /* Access method without creating an object*/

            var result = Calculator.Add(1, 2);

            Console.WriteLine(result);

        }
    }
}
