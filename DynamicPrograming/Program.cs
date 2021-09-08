using System;

namespace DynamicPrograming
{
    class Program
    {
        static int Fibonacci(int nthNumber)
        {
          if(nthNumber <= 2)
           return 1;
          else
           return Fibonacci(nthNumber - 1) + Fibonacci(nthNumber - 2);
        }

        static void Main(string[] args)
        {
            int nthNumber;

            Console.WriteLine("Insert the number for discovery the nth number of fibonacci formule:");
            nthNumber = int.Parse(Console.ReadLine());
             
            Fibonacci(nthNumber);

        }
    }
}
