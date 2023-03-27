using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.ConsoleApp
{
    internal class questao9
    {
        static void Main9(string[] args)
        {
            double nota1 = 0;
            double nota2 = 0;
            double nota3 = 0;
            Console.WriteLine("Digite a nota da primeira prova");
            nota1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a nota da segunda prova");
            nota2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a nota da terceira prova");
            nota3 = Convert.ToDouble(Console.ReadLine());
            double mediaHarmonica = 3/(1/nota1 + 1/nota2 + 1/nota3);
            Console.WriteLine($"\n A média harmônica é {mediaHarmonica}");
        }
    }
}
