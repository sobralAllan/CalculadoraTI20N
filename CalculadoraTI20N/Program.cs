using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraTI20N
{
    class Program
    {
        static void Main(string[] args)
        {
            Control controle = new Control();
            controle.Operacao();//Chamou o método principal
           
            Console.ReadLine();//Ler - Manter a tela aberta
        }//fim do método
    }//fim da classe
}//fim do projeto
