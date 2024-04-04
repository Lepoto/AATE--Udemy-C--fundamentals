using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_Enum_Referecen_Types
{


    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3

    }
    //Reference another example

    public class Person
    {
        public int Age;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //var method = ShippingMethod.Express;

            //Console.WriteLine((int)method);

            // suppose we are receive an int from another api to process/send shipping method
            //var anotherid = 3;
            // this will return the shipping method that holds integer 3
            //Console.WriteLine((ShippingMethod)anotherid);

            //Console.WriteLine(method.ToString());

            // convert string to enum
            /*var methodName = "Express";
            var shipping = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
            Console.WriteLine(shipping);


            // Reference types
            var array1 = new int[3] { 1, 2, 3 };
            var array2 = array1;

            array2[0] = 0;
            Console.WriteLine(string.Format("array1[0]: {0}, array2[0]: {1}", array1[0], array2[0]));*/

            var number = 1;
            Increment(number);
            Console.WriteLine(number);

            var person = new Person() { Age = 20 };
            MakeOld(person);
            Console.WriteLine(person.Age);

        }
        public static void Increment(int number)
        {
            number += 10;
        }
        public static void MakeOld(Person person)
        {
            person.Age += 10;
        }
    }
}
