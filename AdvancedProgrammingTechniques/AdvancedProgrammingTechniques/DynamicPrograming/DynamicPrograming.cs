using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedProgrammingTechniques
{
    class DynamicPrograming
    {
        static int Fibonacci(int nthNumber)
        {
            if (nthNumber <= 2)
                return 1;
            else
                return Fibonacci(nthNumber - 1) + Fibonacci(nthNumber - 2);
        }

        static int Fibonacci_Dynamic(int nthNumber)
        {
            int[] memory = new int[nthNumber + 1];
            string resp = "";

            memory[1] = 1;
            memory[2] = 1;

            for (int i = 3; i <= nthNumber; i++)
            {
                memory[i] = memory[i - 1] + memory[i - 2];
            }

            //Show fibonacci array
            for (int i = 1; i <= nthNumber; i++)
            {
                resp += $"{memory[i]} - ";
            }
            Console.Write($"[ {resp} ]");
           
            return memory[nthNumber];
        }

        public static void OutputDynamicProg() 
        {
          
            int nthNumber;

            Console.WriteLine("Insert the number for discovery the nth number of Fibonacci formule:");
            nthNumber = int.Parse(Console.ReadLine());
            
            int resultNthNumber = Fibonacci(nthNumber);
            
            Console.WriteLine($"\nThe number da {nthNumber}º position of Fibonacci is: \n{resultNthNumber}");

            Console.WriteLine("\nPress Enter for visualize the Fibonnaci implementation dynamic.");

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Response the implementation Fibonacci dynamic formule:");
            Fibonacci_Dynamic(nthNumber);


        }
    }
}
