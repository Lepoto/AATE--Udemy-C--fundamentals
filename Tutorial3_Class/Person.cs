using System;

namespace Tutorial3_Class
{
    public class Person
    {
        public string Name;
        public string Surname;

        public void Introduce()
        {
            Console.WriteLine("Hi, my name is "+ Name + " "+ Surname);
        }
    }
}
