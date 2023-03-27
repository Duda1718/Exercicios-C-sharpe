using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.ConsoleApp
{
    internal class questao28
    {
        static void Main28(string[] args)
        {
            string Fizz = "Fizz";
            string Buzz = "Buzz";
            string FizzBuzz = "FizzBuzz";
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.Write($"{FizzBuzz} ");
                }
                else if (i % 3 == 0)
                {
                    Console.Write($"{Fizz} ");
                }
                else if (i % 5 == 0)
                {
                    Console.Write($"{Buzz} ");
                }
                else
                {
                    Console.Write($"{i} ");
                }
            }

        }
    }
}
