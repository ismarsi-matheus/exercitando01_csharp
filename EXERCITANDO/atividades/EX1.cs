using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCITANDO
{
    internal class EX1
    {
        public void exercisio1()
        {
            Console.WriteLine("Conteúdo do Exercício 1.");
            Console.Clear();
            Console.WriteLine("Verificar Ano Bissexto");
            Console.Write("Digite o ano que deseja verificar: ");

            bool isYearNumber = int.TryParse(Console.ReadLine(), out int ano);
            if (!isYearNumber)
            {
                Console.WriteLine("Entrada inválida! Por favor, insira um ano válido.");
            }
            else
            {
                if (e_bissexto(ano)) // Chama o método e_bissexto para verificar o ano
                {
                    Console.WriteLine($"\nO ano {ano} é bissexto.");
                }
                else
                {
                    Console.WriteLine($"\nO ano {ano} não é bissexto.");
                }
            }

            menu_inicial variavel_cabecalho = new menu_inicial();
            variavel_cabecalho.exibir_cabecalho();

            Exibir_menu variavel_menu = new Exibir_menu();
            variavel_menu.exibir_opcoes_menu();




        }



        private static bool e_bissexto(int ano)
        {
            // Retorna true se o ano for bissexto, false caso contrário
            return (ano % 4 == 0 && ano % 100 != 0) || (ano % 400 == 0);
        }

    }


}


