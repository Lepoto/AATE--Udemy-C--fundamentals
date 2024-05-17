using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decisions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputFilePath = "input.txt";
            string outputFilePath = "output.txt";

            try
            {
                // Read input.txt line by line
                using (StreamReader reader = new StreamReader(inputFilePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        // Check if the line contains "split"
                        if (line.Contains("split"))
                        {
                            // Split the line
                            string[] elements = line.Split(' ');

                            // Write the element with index 4 into output.txt
                            using (StreamWriter writer = new StreamWriter(outputFilePath, true))
                            {
                                writer.Write(elements[4] + " ");
                            }
                        }
                    }
                }

                Console.WriteLine("Processing complete.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
