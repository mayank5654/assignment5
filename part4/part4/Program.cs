using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part4
{
    internal class Program
    {
        static void Main(string[] args)
        {
              // Create an array of integers with a minimum size of 5
                int[] numbers = new int[5];

                // Populate the array with random integer values
                Random random = new Random();
                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] = random.Next(1, 101); // Random integers between 1 and 100
                }

                // Display the array elements
                Console.WriteLine("Array Elements:");
                foreach (int number in numbers)
                {
                    Console.Write(number + " ");
                }
                Console.WriteLine(); // Add a newline for better readability

                // Calculate and display the sum and average of the elements
                int sum = 0;
                foreach (int number in numbers)
                {
                    sum += number;
                }

                double average = (double)sum / numbers.Length;

                Console.WriteLine($"Sum of the elements: {sum}");
                Console.WriteLine($"Average of the elements: {average}");
            
        }

    }
}

