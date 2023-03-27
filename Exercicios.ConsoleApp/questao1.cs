using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.ConsoleApp
{
    internal class questao1
    {
        static void Main1(string[] args)
        {
            decimal altura = 0;
            decimal largura = 0;
            Console.WriteLine("Digite a altura da caixa");
            altura = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Digite a largura da caixa");
            largura = Convert.ToDecimal(Console.ReadLine());
            decimal area = altura * largura;
            Console.WriteLine($"A área da caixa é {area}");
        }
    }
}
