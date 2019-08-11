using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=1; i<=100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write("Fizz");
                }
                if (i % 3 == 0)
                {
                    Console.Write("Buzz");
                }
                if (i % 2 != 0 && i % 3 != 0)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }

            
        }
    }
}
