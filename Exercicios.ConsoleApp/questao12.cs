using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.ConsoleApp
{
    internal class questao12
    {
        static void Main12(string[] args)
        {
            decimal comprimento = 0;
            decimal largura = 0;
            Console.WriteLine("Digite o comprimento do terreno");
            comprimento = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Digite a largura do terreno");
            largura = Convert.ToDecimal(Console.ReadLine());
            decimal area = comprimento * largura;
            Console.WriteLine($"A área do terreno é {area}");
        }
    }
}
