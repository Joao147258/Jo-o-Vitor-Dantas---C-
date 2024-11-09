using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hello.Fundamentos
{
    /// <summary>
    /// 
    /// </summary>
    public class Comentarios
    {
        //public serve para deixar esse metodo publico e eu conseguir importar ele em outro arquivo, no caso estamos importando no arquivo "Program.cs"
            public static void Executar(){
            System.Console.WriteLine("o c# tem o XML comentes, que ocerre quando é posto /// ele abre um sumario e pode ser colocados tags dentro do comentario para se fazer referencias e ficar mais facil a vizualização \n");
            System.Console.WriteLine("comentarios de uma linha: // \n Comentarios de multiplas linhas: /* */ ");
            System.Console.WriteLine("");
            System.Console.WriteLine("atalhos: ctrl+k+c comenta e ctrl+k+u descomenta");
        }

        
    }
}

