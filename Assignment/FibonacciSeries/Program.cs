using System;

namespace FibonacciSeries
{
    internal class Program
    {


        static void Fibonacci(int terms)
        {
            int a = 0, b = 1, next;

            for (int i = 1; i <= terms; i++)
            {
                Console.Write(a + "\n");
                next = a + b;
                a = b;
                b = next;
            }
        }


        static void Main(string[] args)
        {
            Console.Write("Enter number of terms: ");
            int terms = int.Parse(Console.ReadLine());

            Console.WriteLine("Fibonacci Series:");
            Fibonacci(terms);
        }

      
       
    }
}
