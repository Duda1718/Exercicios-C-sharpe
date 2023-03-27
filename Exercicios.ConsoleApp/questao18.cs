using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exercicios.ConsoleApp
{
    internal class questao18
    {
        static void Main18(string[] args)
        {
            decimal a = 0;
            decimal b = 0;
            decimal c = 0;
            Console.WriteLine("Digite o valor do primeiro número");
            a = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Digite o valor do segundo número");
            b = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Digite o valor do terceiro número");
            c = Convert.ToDecimal(Console.ReadLine());
            if (a >= b && b >= c)
            {
                Console.WriteLine($"A ordem decrescente é {a}, {b}, {c}");
            }
            else if (a >= c && c >= b)
            {
                Console.WriteLine($"A ordem decrescente é {a}, {c}, {b}");
            }
            else if (b >= a && a >= c)
            {
                Console.WriteLine($"A ordem decrescente é {b}, {c}, {a}");
            }
            else if (b >= c && c >= a)
            {
                Console.WriteLine($"A ordem decrescente é {b}, {c}, {a}");
            }
            else if (c >= a && a >= b)
            {
                Console.WriteLine($"A ordem decrescente é {c}, {a}, {b}");
            }
            else if (c >= b && b >= a)
            {
                Console.WriteLine($"A ordem decrescente é {c}, {b}, {a}");
            }
            }
           }
        }