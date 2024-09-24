using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividades
{
    public class atv3
    {
        public static void Executar()
        {
            int Indice = 12;
            int Soma = 0;
            int K = 1;

            while (K < Indice)
            {
                K = K + 1;
                Soma = Soma + K;
            }
            System.Console.WriteLine($"O valor da soma é {Soma}");
        }
    }
}