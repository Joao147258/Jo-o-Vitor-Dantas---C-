using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.Fundamentos
{
    public class OperadoresRelacionais
    {
        public static void executar(){
            //resultado sempre vai retornar verdadeiro ou falso
            double nota = 8.0;
            double NotaCorte = 7.0;

            var verificacao = nota < NotaCorte;

            if (verificacao == true)
            {
                System.Console.WriteLine("reprovado");
                System.Console.WriteLine($"Faltou {NotaCorte - nota} ponto(s) para passar");
            }if (verificacao == false)
            {
                System.Console.WriteLine("aprovado");
                System.Console.WriteLine($"com {nota - NotaCorte} ponto(s) a mais");

            }
        }
    }
}