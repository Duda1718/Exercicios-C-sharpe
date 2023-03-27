using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.ConsoleApp
{
    internal class questao6
    {
        static void Main6(string[] args)
        {
            decimal celsius = 0;
            Console.WriteLine("Digite a temperatura em celsius");
            celsius = Convert.ToDecimal(Console.ReadLine());
            decimal conversao = ((celsius * 9 / 5)+32);
            Console.WriteLine($"\n{celsius}ºC equivale a {conversao}F");
        }
    }
}
