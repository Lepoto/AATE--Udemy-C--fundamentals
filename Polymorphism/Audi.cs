using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Audi: Car
    {
        private string brand = "Audi";
        public string Model { get; set; }
        // Default Constructor
        public Audi() { }
        public Audi(int hp, string color, string model) : base(hp, color)
        {
            this.Model = model;
        }

        public void ShowDetails()
        {
            Console.WriteLine("Brand {0}, HP: {1} and Color: {2}", brand, HP, Color);
        }
        // sealed hides methods from being used by inherited classes
        public sealed override void Repair()
        {
            Console.WriteLine("The {0} {1} was repaired", brand, Model);
        }
    }
}
