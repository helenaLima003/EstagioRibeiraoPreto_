using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Atividades;

namespace Atividade_1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Digite o numero da atividade que deseja verificar: ");
            string Escolha = Console.ReadLine();

            switch (Escolha)
            {
                case "1":
                    atv1.Executar();
                    break;
                case "2":
                    atv2.Executar();
                    break;
                case "3":
                    atv3.Executar();
                    break;
                case "4":
                    atv4.Executar();
                    break;
                case "5":
                    atv5.Executar();
                    break;;

            }
        }
    }
}