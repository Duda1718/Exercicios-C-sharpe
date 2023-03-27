using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.ConsoleApp
{
    internal class questao11
    {
        static void Main11(string[] args)
        {
            int numero , i, resultado = 0;
            Console.WriteLine("Digite um número");
            numero = Convert.ToInt32(Console.ReadLine());
            for (i=2; i<=numero/2; i++)
            {
                if (numero % i == 0)
                {
                    resultado++;
                    break;
                }
            }
            if (resultado == 0)
            {
                Console.WriteLine("O número é primo");
            }
            else
            {
                Console.WriteLine("O número não é primo");
            }
            
    }
  }
}
