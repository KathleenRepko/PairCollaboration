﻿using System;
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
            Console.WriteLine("Kevin and Kathleen have succeeded in merging the branches.");

            Console.WriteLine("Please enter a number between 1 and 100.");
            int userNumber = int.Parse(Console.ReadLine());
            if (userNumber <= 50)
                Console.WriteLine("That's a small number.");
            else
                Console.WriteLine("That's a large number.");

            Console.WriteLine("This is Kevin in Kathleen's turf. Watch me now!");


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

            //A pretty DRY FizzBuzz
            for (int i = 1; i < 101; i++)
            {
                string output = "";
                if (i % 3 == 0)
                    output += "Fizz";
                if (i % 5 == 0)
                   output+="Buzz";
                if (i % 3 !=0 && i % 5 != 0)
                    output += i;
                Console.WriteLine(output);
            }
        }
    }
}
