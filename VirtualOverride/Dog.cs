using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualOverride
{
    class Dog : Animal
    {
        public bool IsHappy { get; set; }
        public Dog(string name, int age) : base(name, age)
        {
            
            IsHappy = true;
            
        }

        public override void Eat()
        {
            // to call the eat method from our base
            base.Eat();
        }

        public override void MakeSound()
        {
           // since every animal will make a totally different sound
           // so each animal will implement their own version of Sound
            Console.WriteLine("Wuuf! Wuuf.");
        }
        public override void Play()
        {
            // Some animals play when they are happy so we 
            if (IsHappy)
            {
                base.Play();
            }
        }
    }
}
