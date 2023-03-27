namespace Exercicios.ConsoleApp
{
    //Faça um algoritmo que leia os valores A, B, C e imprima na tela se a soma de A + B é menor que C.
    internal class questao17
    {
        static void Main17(string[] args)
        {
            decimal A = 0;
            decimal B = 0;
            decimal C = 0;
            Console.WriteLine("Digite o valor de A");
            A = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Digite o valor de B");
            B = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Digite o valor de C");
            C = Convert.ToDecimal(Console.ReadLine());
            decimal soma = A + B;
            if (soma < C)
            {
                Console.WriteLine("A soma de A e B é menor que C");
            }
            else if (soma == C) 
            {
                Console.WriteLine("A soma de A e B é igual ao valor de C");
            }
            else {
                Console.WriteLine("A soma de A e B é maior que C");
            }
        }
    }
}

