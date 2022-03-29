using System;
using System.IO;
using System.Threading;
using ProjetoElevador.Model;

namespace ProjetoElevador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Elevador elevador = new Elevador();

            Console.Write("Capacidade do Elevador: ");
            int capacidade = int.Parse(Console.ReadLine());

            Console.Write("Total de Andares: ");
            int andares = int.Parse(Console.ReadLine());

            elevador.Inicializar(capacidade, andares);

            Console.WriteLine();

            while(true)
            {
                Console.WriteLine("1 - Entrar\n2 - Sair\n3 - Subir\n4 - Descer\n5 - Sair do Programa");
                Console.Write("Escolha uma opção: ");
                int escolha = int.Parse(Console.ReadLine());

                if (escolha == 5) {
                    break;
                }

                switch(escolha)
                {
                    case 1:
                        elevador.Entrar();
                        break;
                    case 2:
                        elevador.Sair();
                        break;
                    case 3:
                        elevador.Subir();
                        break;
                    case 4:
                        elevador.Descer();
                        break;
                    default:
                        Console.WriteLine("ESCOLHA INVÁLIDA!");
                        break;
                }
            }
        }
    }
}
