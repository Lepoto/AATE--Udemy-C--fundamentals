using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConcepts
{
    internal class Car
    {
        //Member fields/variable

        // Access modifier private
        private string _name;
        private int _horsePower;
        private string _color;

        // ReadOnly and WriteOnly properties


        // read only variable
        public int MaxSpeed { get; } = 100;

        // write only variable 
        private int _horse;
        public int Horse { set { _horse = value; } }

        // public property
        public string Name { 
            get { return _name; } // Get accessor
            set { 
                if(value == "")
                {
                    _name = "Hello World Default";
                }
                else
                {
                    _name = value;
                }

            } // set accessor
        }


        // Default Constructor

        public Car()
        {
            // set default values
            _name = "Car";
            _horsePower = 0;
            _color = "red";
            
        }

        // Full Parameterised Constructor
        public Car(string Name, string Color, int horsePower = 0)
        {
            this._name = Name;
            this._color = Color;
            this._horsePower = horsePower;
            Console.WriteLine("{0} was created", Name);
        }

        // Partial Specification Constructor

        public Car(string Name, int horsePower = 0)
        {
            this._name = Name;
            this._color = "White";
            this._horsePower = horsePower;
            Console.WriteLine("{0} was created", Name);
        }

        // Member Methods

        public void Drive()
        {
            Console.WriteLine("{0} is driving.", _name);
        }

        public void Stopped()
        {
            Console.WriteLine("{0} has stopped.", _name);
        }

        public void CarDetail()
        {
            Console.WriteLine("This car {0} has color \"{1}\" with horse power {2}", _name, _color, _horsePower);
        }
    }
}
