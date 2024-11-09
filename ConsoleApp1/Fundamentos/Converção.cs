using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hello.Fundamentos
{
    public class Converção
    {
        public static void Executar(){
            // converção implicita -> ocorre quando vamos converter um tipo de dado menos para um maior, aí não precisamos expecificar o tipo que queremos pois o proprío c# faz isso
            int inteiro = 10;
            double quebrado;
            quebrado = inteiro;
            // tbm poderia ser escrito assim:
            // double quebrado = inteiro

            System.Console.WriteLine(quebrado);

            // Converção Explicita -> Ocorre quando vamos converter um valor maior para um menor, e o C# pede para explissitar pois nesse tipo de converção normalmente ocorre perca de dados; sendo necessário colocar o tipo de dado que vamos converter entre parenteses antes do valor que vamos converter
            double nota = 9.7;
            int NotaTruncada;
            NotaTruncada = (int)nota;
            // tbm poderia ser escrito da seguinte forma:
            //int NotaTruncada = (int)nota;

            System.Console.WriteLine(NotaTruncada);

            // string para Numero
            string idadestring = "22";
            int idadeint = int.Parse(idadestring);

            System.Console.WriteLine(idadeint);

            //outra possibilidade é utilizar o comando convert
            idadeint = Convert.ToInt32(idadestring);
            System.Console.WriteLine(idadeint);

            //o jeito mais seguro de fazer essa converção é usando o tryparse, pois se o usuario digitar uma palavra ele retorna 0

            System.Console.WriteLine("digite um numero");
            string palavra = Console.ReadLine();
            int numero;
            int.TryParse(palavra, out numero);
            System.Console.WriteLine(numero);
            // aqui ele pega o que foi digitado em palavra e tenta passar para numero, se ele conseguir, OK se não ele retorna 0

            //este comando poderia ser escrito da seguinte forma: 
            System.Console.WriteLine("digite o segundo numero");
            int.TryParse(Console.ReadLine(), out int numero2);
            System.Console.WriteLine(numero2);
            

        }
    }
}