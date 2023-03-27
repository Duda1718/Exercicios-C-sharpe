using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.ConsoleApp
{
    internal class questao19
    {

            static void Main19(string[] args)
            {
                double peso = 0;
                double altura = 0;
                Console.WriteLine("Digite seu peso");
                peso = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite sua altura em metros");
                altura = Convert.ToDouble(Console.ReadLine());
                double imc = peso / Math.Pow(altura, 2);
                Console.WriteLine($"\n Seu IMC é {imc}");
                if (imc <= 18.5)
                {
                    Console.WriteLine($"\nVocê está abaixo do peso ideal");
                }
                else if (imc > 18.5 && imc <= 25)
                {
                    Console.WriteLine($"\nVocê está dentro do peso ideal");
                }
                else if (imc > 25 && imc <= 30)
                {
                    Console.WriteLine($"\nVocê está acima do peso ideal");
                }
                else if (imc > 30)
                {
                    Console.WriteLine($"\nVocê está na faixa da obesidade");
                }
            }
        }
}
