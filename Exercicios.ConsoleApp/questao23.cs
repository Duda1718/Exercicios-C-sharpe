using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.ConsoleApp
{
    internal class questao23
    { 
        static void Main23(string[] args)
        {
            for (int i = 101; i <= 199; i+=2)
            {
                int impar = Convert.ToInt32(i);
                Console.WriteLine(impar);
            }
        }
    }
}
