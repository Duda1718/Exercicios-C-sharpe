using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.ConsoleApp
{
    internal class questao27
    {
        static void Main27(string[] args)
        {
            Console.WriteLine("Digite um número:");
            int numero = Convert.ToInt32(Console.ReadLine());
            int primeiroNum = 0;
            int segundoNum = 1;
            int proximoNum = primeiroNum + segundoNum;
            Console.Write ($"A sequência de Fibonacci até {numero} é:)\n {primeiroNum}, {segundoNum}");
            while (proximoNum <= numero)
            {
                Console.Write($", {proximoNum}");
                primeiroNum = segundoNum;
                segundoNum = proximoNum;
                proximoNum = primeiroNum + segundoNum;
            }

        }

    }
}

