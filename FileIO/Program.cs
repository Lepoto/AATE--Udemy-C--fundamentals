using System.IO;

namespace FileIO
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Writing a lines to a file

            /*string[] lines = { "First line", "Second Line", "Third line" };


            File.WriteAllLines(@"C:\Users\Documents\testPercy.txt", lines);
*/

            // Reading text 

            /*string Text = System.IO.File.ReadAllText(@"C:\Users\lepot\OneDrive\Documents\AATE Workreadiness.txt");

            Console.WriteLine("TextFile contains the following : {0}",Text);

            // Reading lines 
            string[] lines = File.ReadAllLines(@"C:\Users\lepot\OneDrive\Documents\AATE Workreadiness.txt");

            Console.WriteLine("Contents of Textfile : ");
            foreach (string line in lines)
            {
                Console.WriteLine("\t" + line);
            }*/
            Console.ReadKey();
        }
    }
}
