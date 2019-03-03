using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSequenceARGS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            int argumentInput = int.Parse(args[0]);
            if (argumentInput <= 47)
            {
                int secondPrevious = 0;
                int previous = 1;
                int count = argumentInput;
                int current = 0;
                Console.WriteLine($"{secondPrevious}\n{previous}");

                for (int place = 3; place <= count; place++)
                {
                    current = secondPrevious + previous;
                    Console.WriteLine(current);
                    secondPrevious = previous;
                    previous = current;
                }
            }
            else
            {
                Console.WriteLine("This program can generate atmost 47 Fibonacci Numbers.\n" +
                    "Please rerun the program enter an argument less than or equal to 47\n" +
                    "Press Enter to end this session...");
                Console.ReadKey();
            }
        }
    }
}
