using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace hello.Fundamentos
{
    public class FormatandoNumeros
    {
        public static void Executar(){
            double Numero = 15.175;
            //(Numero.Tostring("")) -> o comando Numero.tostring é para dizer ao c# que queremos fazer uma formatação do valor que foi posto dentro da variavel Numero e o ("") que usamos depois é para colocarmos o tipo de formatção que será usada

            //nesse exemplo ele converte para uma casa decimal
            System.Console.WriteLine(Numero.ToString("f1"));
            //aqui indica que quermos que ele formate para dinheiro
            System.Console.WriteLine(Numero.ToString("c"));
            //formatar para porcentual
            System.Console.WriteLine(Numero.ToString("p"));
            //deixar apenas duas casas decimais
            System.Console.WriteLine(Numero.ToString("#.##"));

            CultureInfo Cultura = new CultureInfo("en-us");
            System.Console.WriteLine(Numero.ToString("c", Cultura));
            



        }
    }
}