using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.ConsoleApp
{
    internal class questao29
    {
        static void Main29(string[] args)
        {
            for (int i = 0; i <= 10; i++)
            {
                for (int j = 0; j <= 10; j++)
                {
                    int tabuada = i * j;
                    Console.Write($"{i} * {j} = {tabuada}\n");
                }
                Console.WriteLine();
            }

        }
    }
}
