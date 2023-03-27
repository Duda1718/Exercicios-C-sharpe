using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.ConsoleApp
{
    internal class questao13
    {
        static void Main13(string[] args)
        {
        double broas = 0;
        double paes = 0;
        Console.WriteLine("Digite a quantidade de broas vendidas no dia");
        broas = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite a quantidade de pães vendidos no dia");
        paes = Convert.ToDouble(Console.ReadLine());
        double totalDeVendas = broas * 1.5 + paes * 0.12;
        Console.WriteLine($"\n O total arrecadado é R${totalDeVendas}");
        Console.WriteLine($"\n O valor que deve ser guardado é de R${totalDeVendas * 0.1}");
        }
    }
}
