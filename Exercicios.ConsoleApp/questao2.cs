using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.ConsoleApp
{
    class program
    {
        static void Main2(string[] args)
        {
            decimal fehrenheit = 0;
            Console.WriteLine("Digite a temperatura em fehrenheit");
            fehrenheit = Convert.ToDecimal(Console.ReadLine());
            decimal conversao = ((fehrenheit - 32) * 5 / 9);
            Console.WriteLine($"\n{fehrenheit}F equivale a {conversao}ºC");
        }
    }
}
