using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.ConsoleApp
{
    internal class questao24
    {
        static void Main24(string[] args)
        {
            int soma = 0;
            for (int i = 3; i <= 499; i += 2) {
                {
                    if (i % 3 == 0) {
                        soma += i;
                    }
                }
            }
        Console.WriteLine($"A soma é {soma}");
        }
    }
}

