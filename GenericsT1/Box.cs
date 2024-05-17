using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsT1
{
    // Generic means its not related to a specific type
    // T means Type, Box accept data any type
    // Box<T> is now a generic
    internal class Box<T>
    {
        private T content;

        // Default construtor
        public Box() { }
        
        // Parameter constructor
        public Box(T contentValue)
        {
            this.content = contentValue;
        }

        public void UpdateContent(T contentValue)
        {
            content = contentValue;
            Console.WriteLine("Updated Content to \"{0}\"", content);
        }

        public T GetContent()
        {
            return content;
            //Console.WriteLine("Updated Content to {0}", content);
        }

    }
}
