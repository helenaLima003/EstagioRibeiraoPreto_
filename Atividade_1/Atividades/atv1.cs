using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividades
{
    public class atv1
    {
        public static void Executar()
        {
            bool Pertence(int num)
            {
                if (num == 0 || num == 1) return true;

                int a = 0, b = 1, soma = 0;

                while (soma < num)
                {
                    soma = a + b;
                    a = b;
                    b = soma;
                }

                return soma == num;
            }

            Console.WriteLine("Informe um número:");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine("O número pertence à sequência de Fibonacci? ");

            if (Pertence(numero))
            {
                Console.WriteLine("Sim");
            }
            else
            {
                Console.WriteLine("Não");
            }
        }
    }
}