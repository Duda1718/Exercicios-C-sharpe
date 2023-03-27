using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.ConsoleApp
{
    internal class questao26
    {
        static void Main26(string[] args)
        {
            int fatorial = 0;
            Console.WriteLine("Digite o valor de N");
            int N = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= N; i++) {
                fatorial = 1;
                for (int j = 1; j <= i; j++) {
                    fatorial *= j;
            } 
          }
            Console.WriteLine($"{N}! = {fatorial}");
        }
    }
}
