using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Car
    {
        private string _name;
        private int _hp;
        private string _color;

        public void setName(string name)
        {
            _name = name;
        }
        public Car()
        {
            _hp = 0;
            _name = "Car";
            _color = "White";
        }

        public Car(string name, int hp = 0, string color="White")
        {
            _name = name;
            // Console.WriteLine(_name + " was created!.");
            _hp = hp; ;
            _color = color;
        }

        public void Drive()
        {
            Console.WriteLine(_name + " is driving");
        }
        public void Stop()
        {
            Console.WriteLine(_name + " has stopped");
        }
        public void Description()
        {
            Console.WriteLine(_name + " is a " + _color + " with " + _hp+" horsepower!.");
        }
    }
}
