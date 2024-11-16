using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.Fundamentos
{
    public class OperadoresLogicos
    {
        public static void executar(){
            //Neste exemplo vamos trabalhar com o seguinte contexto: quero comprar um tv nova, porem preciso de dinheiro extra para isso então arrumei dois serviços, um na terça e um na quinta se ambos derem certo, vou comprar uma tv de 50" se apenas um der certo vou comprar uma tv de 32" se nenhum der certo não vou comprar nenhuma tv

            var TrabalhoTerca = true;
            var TrabalhoQuinta = false;

            
            if (TrabalhoTerca == true && TrabalhoQuinta == true )
            {
             System.Console.WriteLine("comprar tv de 50");
            } if (TrabalhoTerca == true | TrabalhoQuinta == false)
            {
                System.Console.WriteLine("comprar Tv de 32");
            }if (TrabalhoTerca == false | TrabalhoQuinta == true)
            {
                System.Console.WriteLine("comprar tv de 32");
            }if(TrabalhoTerca == false && TrabalhoQuinta == false)
            {
                System.Console.WriteLine("apenas tomar sorvete");
            }

            // ou poderia ser escrito da seguinte maneira:

            bool TV50 = TrabalhoTerca == true && TrabalhoQuinta == true;
             System.Console.WriteLine($"tv de 50 {TV50}");

            var TV32 = TrabalhoTerca ^ TrabalhoQuinta;
             System.Console.WriteLine($"comprar tv de 32 {TV32}");

            bool sorvete = TrabalhoTerca == false && TrabalhoQuinta == false;
             System.Console.WriteLine($"Apenas tomar sorvete {sorvete}");

        }
    }
}