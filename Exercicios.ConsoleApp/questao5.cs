using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.ConsoleApp
{
    internal class questao5
    {
        static void Main5(string[] args)
        {
            double raio = 0;
            Console.WriteLine("Digite o valor do raio da esfera");
            raio = Convert.ToDouble(Console.ReadLine());
            double volume = Math.PI * Math.Pow(raio, 3) * 4/3;
            Console.WriteLine($"\n O volume da esfera é {volume}");
        }
    }
}
