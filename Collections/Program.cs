using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int[] numbers = new int[10];

            for(int i=0; i<numbers.Length; i++)
            { numbers[i] = i; }

            for(int j=0; j<numbers.Length; j++) 
            {
                Console.WriteLine("Elements {0} = {1}", j, numbers[j]);
            }
            int counter = 0;
            foreach (int k in numbers)
            {
                Console.WriteLine("Elements {0} = {1}", counter, k);
                counter++;
            } */

            // Challange create an array with 5 of your friendds name, create a foreach loop which greets all of them
            /*string[] friends = new string[] { "John", "Percy", "Alfred", "Acer", "Lepoto" };
            int counter = 0;

            foreach(string friend in friends)
            {
                Console.WriteLine("{0} Hi there, {1} my friend.",counter, friend);
                counter++;
            }*/

            // 2D array 
            /* int[,] matrix = new int[,]
            {
                {1, 2, 3, 4 }, //row 0
                {5, 6, 7, 8 }, //row 1
                {9, 10, 11, 12 }, //row 2
            };

            Console.WriteLine("Central value is {0}", matrix[2,0]);
            */

            /*string[,] array3D = new string[3,2]
            {
                {"one", "two"},
                {"three", "four"},
                {"five","six"},
            };

            string input = Console.ReadLine();
            array3D[1,1] = input;
            // Console.WriteLine(array3D[1, 1]);

            // Dimensions
            int dimensions = array3D.Rank; // to find the diemensions of an array
            Console.WriteLine(dimensions);*/

            Console.WriteLine(Add(10, 1));

        }
        // access modifier static return-type method name parameters

        public static int Add(int a, int b)
        {
            int result = a + b;

            return result;
        }


    }
}
