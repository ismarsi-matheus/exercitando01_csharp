using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCITANDO
{
    internal class EX2
    {

        public void exercisio2()
        {
            Console.WriteLine("Verificar se a letra é uma vogal ou consoante.");
            Console.Write("Digite uma letra: ");
            char letra = Console.ReadKey().KeyChar; // Lê uma única letra
            Console.WriteLine(); // Pula para a linha seguinte após o caractere

            letra = char.ToLower(letra); // Converte para minúscula

            // Verifica se é uma letra
            if (char.IsLetter(letra))
            {
                // Verifica se é vogal
                if ("aeiou".Contains(letra))
                {
                    Console.WriteLine($"A letra '{letra}' é uma vogal.");
                }
                else
                {
                    Console.WriteLine($"A letra '{letra}' é uma consoante.");
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida! Por favor, insira uma letra.");
            }




            menu_inicial variavel_cabecalho = new menu_inicial();
            variavel_cabecalho.exibir_cabecalho();

            Exibir_menu variavel_menu = new Exibir_menu();
            variavel_menu.exibir_opcoes_menu();
        }






    }
}
