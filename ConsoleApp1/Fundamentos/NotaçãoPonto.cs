using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hello.Fundamentos
{
    public class NotaçãoPonto
    {
        public static void Executar(){
            var saudacao = "ola".ToUpper().Insert(3, " World").Replace("World", "Mundo");
            System.Console.WriteLine(saudacao);
        }
    }
}