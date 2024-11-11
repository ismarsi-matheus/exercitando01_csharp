using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCITANDO
{
    internal class EX6
    {
        public void exercisio6()
        {
            Console.WriteLine("Verificação de Número Primo.");
            Console.Write("Digite um número: ");
            bool numeroValido = int.TryParse(Console.ReadLine(), out int numero);

            if (numeroValido)
            {
                if (isPrimo(numero))
                {
                    Console.WriteLine($"O número {numero} é PRIMO.");
                }
                else
                {
                    Console.WriteLine($"O número {numero} não é PRIMO.");
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida! Por favor, insira um número válido.");
            }

            menu_inicial variavel_cabecalho = new menu_inicial();
            variavel_cabecalho.exibir_cabecalho();

            Exibir_menu variavel_menu = new Exibir_menu();
            variavel_menu.exibir_opcoes_menu();
        }




        private static bool isPrimo(int numero)
        {
            if (numero <= 1)
                return false; // 0 e 1 não são primos

            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0)
                    return false; // Encontrou um divisor, não é primo
            }

            return true; // Se não encontrou divisores, é primo
        }







    }
}
