using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Atividades
{
    public class atv2
    {
        public static void Executar()
        {
            System.Console.WriteLine("Digite uma Palavra: ");
            string Palavra = Console.ReadLine();

        static int Contar(string Texto)
        {
                int i = 0;
                foreach (char a in Texto)
                {
                    if (a == 'a' || a == 'A')
                    {
                        i++;
                    }
                }
                return i;
            }

            int QuantidadeDeA = Contar(Palavra);

            if (QuantidadeDeA > 0)
            {
                System.Console.WriteLine($"A letra 'a' aparece {QuantidadeDeA} vezes.");
            }
            else
            {
                System.Console.WriteLine("A letra 'a' não apareceu nenhuma vez.");
            }
        }
    }
}