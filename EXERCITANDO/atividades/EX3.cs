using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCITANDO
{
    internal class EX3
    {

        private void exercisio3()
        {
            Console.WriteLine("Cálculo do IMC.");
            Console.Write("Digite o seu peso (em kg): ");
            bool pesoValido = double.TryParse(Console.ReadLine(), out double peso);

            Console.Write("Digite a sua altura (em metros): ");
            bool alturaValida = double.TryParse(Console.ReadLine(), out double altura);

            if (pesoValido && alturaValida && altura > 0) // Verifica se o peso e a altura são válidos
            {
                double imc = peso / (altura * altura);
                Console.WriteLine($"Seu IMC é: {imc:F2}");

                // Classificação do IMC
                if (imc < 18.5)
                {
                    Console.WriteLine("Classificação: Abaixo do peso.");
                }
                else if (imc < 24.9)
                {
                    Console.WriteLine("Classificação: Peso normal.");
                }
                else if (imc < 29.9)
                {
                    Console.WriteLine("Classificação: Acima do peso.");
                }
                else
                {
                    Console.WriteLine("Classificação: Obeso.");
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida! Por favor, insira valores válidos para peso e altura.");
            }


            menu_inicial variavel_cabecalho = new menu_inicial();
            variavel_cabecalho.exibir_cabecalho();

            Exibir_menu variavel_menu = new Exibir_menu();
            variavel_menu.exibir_opcoes_menu();
        }








    }
}
