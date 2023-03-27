using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.ConsoleApp
{
    //Crie um programa para calcular o salário total de um vendedor.
    //Deverá ser informado o salário base e o total de
    // vendas.A comissão é calculada com um percentual(informado pelo usuário)
    // sobre o total de vendas.
    internal class questao7
    {
        static void Main7(string[] args)
        {
            decimal salarioBase = 0;
            decimal numeroVendas = 0;
            decimal valorVendas = 0;
            decimal comissao;
            decimal salarioTotal;
            Console.WriteLine("Digite o salário base");
            salarioBase = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Digite o total de vendas");
            numeroVendas = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Digite o valor de cada venda");
            valorVendas = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Digite a porcentagem decomissão por cada venda");
            comissao = Convert.ToDecimal(Console.ReadLine());
            salarioTotal = (salarioBase + numeroVendas * valorVendas * comissao / 100);
            Console.WriteLine($"\nO salário total será {salarioTotal}");
        }
    }
}
