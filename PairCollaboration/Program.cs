using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairCollaboration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kevin and Kathleen are working together as collaborators.");

            Console.WriteLine("Please enter a number between 1 and 10.");
            int userNumber = int.Parse(Console.ReadLine());
            if (userNumber <= 5)
                Console.WriteLine("That's a small number.");
            else
                Console.WriteLine("That's a large number.");


            for (int i = 1; i < 15; i++)
            {
                if (i % 4 == 0)
                {
                    Console.WriteLine(i);
                }

                else
                {
                    Console.WriteLine("I am not evenly divisible by 4.");
                }

            }



            //Broken FizzBuzz
            for (int i = 1; i < 101; i++)
            {
                if (i % 3 == 0)
                    Console.Write("Fizz");
                if (i % 5 == 0)
                    Console.Write("Buzz");
                else
                    Console.Write(i);
            }
        }
    }
}
