using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.ConsoleApp {
    internal class questao16
    {
        // Faça um algoritmo para ler o salário de um funcionário e aumentá-lo em 15%.
        // Após o aumento, desconte 8% deimpostos.
        // Imprima o salário inicial, o salário com o aumento e o salário final.
        static void Main16(string[] args)
        {
            decimal salario = 0;
            Console.WriteLine("Digite seu salário");
            salario = Convert.ToDecimal(Console.ReadLine());
            decimal aumento = (salario * 1.15m);
            decimal imposto = (aumento * 0.92m);
            Console.WriteLine
            ($"Seu salário é {salario}\nSeu salário com aumento é {aumento}\nSeu salário descontados os impostos é {imposto}");
        }
    }
}
