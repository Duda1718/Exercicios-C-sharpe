using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.ConsoleApp
{
    internal class questao14
    {
        static void Main14(string[] args)
        {
            string nome;
            double idade= 0;
            Console.WriteLine("Digite seu nome");
            nome = Console.ReadLine();
            Console.WriteLine("Digite sua idade");
            idade = Convert.ToDouble(Console.ReadLine());
            double diasTotais = idade * 365;
            Console.WriteLine($"\n {nome}, você já viveu {diasTotais} dias!");
        }
    }
}
