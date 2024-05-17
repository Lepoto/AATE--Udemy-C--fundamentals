using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualOverride
{
    class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsHungry { get; set; }

        public Animal(string name, int age)
        {   
            Name = name;
            Age = age;
            // in case all an
            IsHungry = true;
            
        }
        // an empty virtual method for other classes to override
        public virtual void MakeSound()
        {

        }

        // virtual method called eat which sub classes can override
        public virtual void Eat()
        {
            if (IsHungry)
            {
                Console.WriteLine("{0} is eating", Name);
            }
            else
            {
                Console.WriteLine("{0} is not hungry.", Name);
            }
        }

        public virtual void Play()
        {
            Console.WriteLine("{0} is playing.", Name);
        }
    }
}
