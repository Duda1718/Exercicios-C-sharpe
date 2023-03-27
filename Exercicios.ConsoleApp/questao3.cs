using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exercicios.ConsoleApp
{
    internal class questao3
    {
        static void Main3(string[] args)
        { 
        double raio = 0;
        double altura = 0;
        Console.WriteLine("Digite o valor do raio do cilindro");
        raio = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite o valor da altura do cilindro");
        altura = Convert.ToDouble(Console.ReadLine());
        double volume = Math.PI * Math.Pow(raio, 2) * altura;
        Console.WriteLine($"\n O volume do cilindro é {volume}");
       
        }
    }
}
