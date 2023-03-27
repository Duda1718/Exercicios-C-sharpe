using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.ConsoleApp
{
    internal class questao4
    {
        static void Main4(string[] args)
        {
            double kmInicial;
            double kmFinal;
            double quantidadeCombustivel = 10;
            double kmPercorrido = 0;
            double consumo = 0;
            Console.WriteLine("Digite a quilometragem inicial");
            kmInicial = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quilometragem final");
            kmFinal = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual a quantidade de combustível foi utilizado?");
            kmPercorrido = (kmFinal - kmInicial);
            quantidadeCombustivel = double.Parse(Console.ReadLine());
            consumo = quantidadeCombustivel / kmPercorrido;
            Console.WriteLine($"\n O consumo de combustível é {consumo} para {kmPercorrido}km");
            Console.ReadLine();
        }
    }
}
