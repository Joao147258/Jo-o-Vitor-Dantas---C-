using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.Fundamentos
{
    public class OperadoresAritimeticos
    {
        public static void Executar(){
            //desconto
            var preco = 1000;
            var desconto = 10;
            var Divisao = decimal.Divide(desconto,100);
            

            var precoComDesconto = preco - (preco * Divisao) ;
            System.Console.WriteLine(precoComDesconto);

            //imc
            var peso = 98;
            var altura = 1.75;
            double resultado = peso / (altura * altura);

            System.Console.WriteLine(resultado);
        }
    }
}