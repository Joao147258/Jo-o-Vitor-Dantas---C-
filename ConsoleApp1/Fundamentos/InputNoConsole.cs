using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hello.Fundamentos
{
    public class InputNoConsole
    {
        public static void Executar(){
            System.Console.WriteLine("Digite um ID com 3 caracteres");
            var IDUsuario = Console.ReadLine();
            //var checID = IDUsuario.Length;
            if (IDUsuario.Length < 3 )
            {
                System.Console.WriteLine("você digitou menos de 3 caracteres");     
                                                                
            } else
            {
                System.Console.WriteLine($"seja bem vindo {IDUsuario}");
                System.Console.WriteLine("qual o seu salario");         
                Double salario = double.Parse(Console.ReadLine());
                System.Console.WriteLine($"bem vindo {IDUsuario} seu salario é {salario}"); 
                
            }
        }
    }
}