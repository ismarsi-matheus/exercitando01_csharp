using EXERCITANDO;
using System;
using System.Linq;
using System.Threading;

namespace Aula2exercisios
{
    public class Program
    {
        static void Main(string[] args)
        {
           menu_inicial variavel_cabecalho = new menu_inicial();
            variavel_cabecalho.exibir_cabecalho();
            //chmando o cabecalho 

            Exibir_menu variavel_menu = new Exibir_menu();
            variavel_menu.exibir_opcoes_menu();
            //chamando o menu 
        }

        
    }
}
