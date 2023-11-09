using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Part 2: Loops

         
                // Part 1: For loop to display the first 10 natural numbers
                Console.WriteLine("First 10 Natural Numbers (for loop):");
                for (int i = 1; i <= 10; i++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine(); // Add a newline for better readability

                // Part 2: While loop to print the first 10 even natural numbers
                Console.WriteLine("First 10 Even Natural Numbers (while loop):");
                int evenCount = 0;
                int evenNumber = 2;

                while (evenCount < 10)
                {
                    Console.Write(evenNumber + " ");
                    evenCount++;
                    evenNumber += 2;
                }
                Console.WriteLine(); // Add a newline for better readability

                // Part 3: Do-while loop to print the first 10 odd natural numbers
                Console.WriteLine("First 10 Odd Natural Numbers (do-while loop):");
                int oddCount = 0;
                int oddNumber = 1;

                do
                {
                    Console.Write(oddNumber + " ");
                    oddCount++;
                    oddNumber += 2;
                } while (oddCount < 10);
            }
        

    }
}
        

    

