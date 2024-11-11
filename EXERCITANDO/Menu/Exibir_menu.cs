using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EXERCITANDO
{
    internal class Exibir_menu
    {
        public  void exibir_opcoes_menu()
        {
            Console.WriteLine("\nMenu de Opções:");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("1 - Exercício 1");
            Console.WriteLine("2 - Exercício 2");
            Console.WriteLine("3 - Exercício 3");
            Console.WriteLine("4 - Exercício 4");
            Console.WriteLine("5 - Exercício 5");
            Console.WriteLine("6 - Exercício 6");
            Console.Write("\nDigite a opção escolhida: ");

            int opcao_escolhida;
            if (!int.TryParse(Console.ReadLine(), out opcao_escolhida))
            {
                Console.WriteLine("\nEntrada inválida! Tente novamente.");
                Thread.Sleep(2000);
                Console.Clear();
                exibir_cabecalho();
                exibir_opcoes_menu();
                return;
            }

            switch (opcao_escolhida)
            {
                case 0:
                    Sair(); // Chama o método Sair para encerrar o programa
                    break;
                case 1:
                    executar_exercisio(1);
                    break;
                case 2:
                    executar_exercisio(2);
                    break;
                case 3:
                    executar_exercisio(3);
                    break;
                case 4:
                    executar_exercisio(4);
                    break;
                case 5:
                    executar_exercisio(5);
                    break;
                case 6:
                    executar_exercisio(6);
                    break;
                default:
                    Console.WriteLine("\nOpção inválida! Tente novamente.");
                    Thread.Sleep(2000);
                    Console.Clear();
                    exibir_cabecalho();
                    exibir_opcoes_menu();
                    break;
            }
        }

        private static void Sair()
        {
            Console.Clear();
            Console.WriteLine("Encerrando o programa...");
            Console.WriteLine(@"
░██████╗░█████╗░██╗███╗░░██╗██████╗░░█████╗░░░░░░░░░░
██╔════╝██╔══██╗██║████╗░██║██╔══██╗██╔══██╗░░░░░░░░░
╚█████╗░███████║██║██╔██╗██║██║░░██║██║░░██║░░░░░░░░░
░╚═══██╗██╔══██║██║██║╚████║██║░░██║██║░░██║░░░░░░░░░
██████╔╝██║░░██║██║██║░╚███║██████╔╝╚█████╔╝██╗██╗██╗
╚═════╝░╚═╝░░╚═╝╚═╝╚═╝░░╚══╝╚═════╝░░╚════╝░╚═╝╚═╝╚═╝");
            Thread.Sleep(3000);
        }



        private static void executar_exercisio(int numero_exercisio)
        {
            Console.Clear();
            Console.WriteLine($"Exercício {numero_exercisio}");
            Console.WriteLine($"Executando o exercício {numero_exercisio}...\n");

            switch (numero_exercisio)
            {
                case 1:
                    EX1 eX1 = new EX1();
                    eX1.exercisio1();

                    break;
                case 2:
                    EX2 eX2 = new EX2();
                    eX2.exercisio2();
                    break;
                case 3:
                    EX3 eX3 = new EX3();
                    eX3.exercisio3();
                    break;
                case 4:
                    EX4 eX4 = new EX4();
                    eX4.exercisio4(); 
                    break;
                case 5:
                    EX5 eX5 = new EX5();
                    eX5.exercisio5();
                    break;
                case 6:
                    EX6 eX6 = new EX6();
                    eX6.exercisio6(); 
                    break;
            }

            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal...");
            Console.ReadKey();
            Console.Clear();
            exibir_cabecalho();
            exibir_opcoes_menu();
        }







    }
}
