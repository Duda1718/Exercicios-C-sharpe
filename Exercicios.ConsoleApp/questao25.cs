using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.ConsoleApp
{
    internal class questao25
    {
            static void Main25(string[] args)
            {
            Console.WriteLine("Digite o valor de N");
            int N = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i <= 10; i ++)
                {
                int tabuada = i * N;
                Console.WriteLine($"{i} * {N} = {tabuada}");
            }
                
            }
        }
}
