using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCITANDO
{
    internal class EX5
    {
        public void exercisio5()
        {
            Console.WriteLine("Verificação da Nota do Aluno.");
            Console.Write("Digite a nota do aluno: ");
            bool notaValida = double.TryParse(Console.ReadLine(), out double nota);

            if (notaValida)
            {
                if (nota >= 7)
                {
                    Console.WriteLine("O aluno está APROVADO.");
                }
                else if (nota >= 5)
                {
                    Console.WriteLine("O aluno está em RECUPERAÇÃO.");
                }
                else
                {
                    Console.WriteLine("O aluno está REPROVADO.");
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida! Por favor, insira uma nota válida.");
            }


            menu_inicial variavel_cabecalho = new menu_inicial();
            variavel_cabecalho.exibir_cabecalho();

            Exibir_menu variavel_menu = new Exibir_menu();
            variavel_menu.exibir_opcoes_menu();
        }






    }
}
