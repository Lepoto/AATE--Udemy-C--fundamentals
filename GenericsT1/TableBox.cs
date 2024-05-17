using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsT1
{
    // Multiple generic types in a class
    internal class TableBox<TFirst, TSecond>
    {
        public TFirst First { get; set; }
        public TSecond Second { get; set; }

        public TableBox(TFirst first, TSecond second)
        {
            this.First = first;
            this.Second = second;
            
        }

        public void Display()
        {
            Console.WriteLine("First : {0}, Second : {1}", First, Second);
        }
    }
}
