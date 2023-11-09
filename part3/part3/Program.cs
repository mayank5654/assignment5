using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part3
{
    internal class Program
    {
        static void Main(string[] args)
        {
  // Print the first 10 Fibonacci numbers using a for loop
                Console.WriteLine("First 10 Fibonacci Numbers:");

                for (int i = 0; i < 10; i++)
                {
                    Console.Write(Fibonacci(i) + " ");
                }
                Console.WriteLine(); // Add a newline for better readability
            }

            static int Fibonacci(int n)
            {
                if (n <= 1)
                {
                    return n;
                }
                else
                {
                    return Fibonacci(n - 1) + Fibonacci(n - 2);
                }
            }
        

    }
}

