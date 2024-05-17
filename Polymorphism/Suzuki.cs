using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Suzuki: Car
    {
        private string brand = "Suzuki";
        public string Model { get; set; }
        // Default Constructor
        public Suzuki() { }
        public Suzuki(int hp, string color, string model) : base(hp, color)
        {
            this.Model = model;
        }

        // It has priority over the default ShowDetails in the base
        // this get called when we create an object of this class, not the base clase

        public new void ShowDetails()
        {
            Console.WriteLine("Brand {0}, HP: {1} and Color: {2}", brand, HP, Color);
        }

        public sealed override void Repair()
        {
            Console.WriteLine("The {0} {1} was repaired", brand, Model);
        }
    }
}
