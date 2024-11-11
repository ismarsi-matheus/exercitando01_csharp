using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCITANDO
{
    internal class EX4
    {
        public void exercisio4()
        {
            Console.WriteLine("Verificação de Data.");
            Console.Write("Digite o dia: ");
            bool diaValido = int.TryParse(Console.ReadLine(), out int dia);

            Console.Write("Digite o mês: ");
            bool mesValido = int.TryParse(Console.ReadLine(), out int mes);

            Console.Write("Digite o ano: ");
            bool anoValido = int.TryParse(Console.ReadLine(), out int ano);

            if (diaValido && mesValido && anoValido)
            {
                try
                {
                    DateTime dataInformada = new DateTime(ano, mes, dia);
                    DateTime dataAtual = DateTime.Now;

                    if (dataInformada < dataAtual)
                    {
                        Console.WriteLine($"A data {dataInformada.ToShortDateString()} é anterior à data atual {dataAtual.ToShortDateString()}.");
                    }
                    else if (dataInformada > dataAtual)
                    {
                        Console.WriteLine($"A data {dataInformada.ToShortDateString()} é posterior à data atual {dataAtual.ToShortDateString()}.");
                    }
                    else
                    {
                        Console.WriteLine("A data informada é igual à data atual.");
                    }
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Data inválida! Por favor, insira uma data válida.");
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida! Por favor, insira valores válidos para dia, mês e ano.");
            }


            menu_inicial variavel_cabecalho = new menu_inicial();
            variavel_cabecalho.exibir_cabecalho();

            Exibir_menu variavel_menu = new Exibir_menu();
            variavel_menu.exibir_opcoes_menu();
        }






    }
}
