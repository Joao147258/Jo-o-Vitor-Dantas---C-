using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hello.Fundamentos
{
    public class Interpolação_de_Strings
    {
        public static void Executar(){
            string nome = "Notebook Gamer";
            string marca = "Dell";
            var preco = 5000.00;

            System.Console.WriteLine("o {0} da marca {1} custa {2}", nome, marca, preco);
            //ou
            System.Console.WriteLine($"o {nome} da marca {marca} custa {preco}");
        }
    }
}