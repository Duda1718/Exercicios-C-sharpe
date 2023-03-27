using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.ConsoleApp
{
    internal class questao10
    {
        static void Main10(string[] args)
        {
            double nota1 = 0;
            double nota2 = 0;
            double peso1 = 0;
            double peso2 = 0;
            Console.WriteLine("Digite a nota da primeira prova");
            nota1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o peso da nota da primeira prova em decimal");
            peso1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a nota da segunda prova");
            nota2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o peso da nota da segunda prova em decimal");
            peso2 = Convert.ToDouble(Console.ReadLine());
            double mediaPonderada = (nota1 * peso1 + nota2 * peso2);
            Console.WriteLine($"\n A média harmônica é {mediaPonderada}");
        }
    }
}
