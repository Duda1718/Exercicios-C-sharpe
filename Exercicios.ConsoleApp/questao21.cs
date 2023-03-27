using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.ConsoleApp
{
    internal class questao21
    {
        static void Main21(string[] args)
        {
            int A, B, C;
            Console.WriteLine("Digite um valor inteiro para A");
            A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite um valor inteiro para B");
            B = Convert.ToInt32(Console.ReadLine());
            if (A == B)
            {
             C = A + B;
            }
            else
            {
             C = A * B;
            }
            Console.WriteLine($"O resultado é {C}");
        }
    }
}
