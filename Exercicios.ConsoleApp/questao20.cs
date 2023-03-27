using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.ConsoleApp
{
    internal class questao20
    {
        static void Main20(string[] args)
        {
            {
                int numero = 0;
                Console.WriteLine("Digite um número");
                numero = Convert.ToInt32(Console.ReadLine());
                if (numero % 2 == 0)
                {
                    Console.WriteLine("O número é par");
                }
                else
                {
                    Console.WriteLine("O número é ímpar");
                }
            }
        }
    }
}
