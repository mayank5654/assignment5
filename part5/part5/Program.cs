using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                // Ask the user to input their exam score as a percentage
                Console.Write("Enter your exam score as a percentage: ");
                if (double.TryParse(Console.ReadLine(), out double score))
                {
                    // Use an if-else statement to determine and display the letter grade
                    if (score >= 90)
                    {
                        Console.WriteLine("Your letter grade is: A");
                    }
                    else if (score >= 80)
                    {
                        Console.WriteLine("Your letter grade is: B");
                    }
                    else if (score >= 70)
                    {
                        Console.WriteLine("Your letter grade is: C");
                    }
                    else if (score >= 60)
                    {
                        Console.WriteLine("Your letter grade is: D");
                    }
                    else
                    {
                        Console.WriteLine("Your letter grade is: F");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid percentage.");
                }
            
        }

    }
}

