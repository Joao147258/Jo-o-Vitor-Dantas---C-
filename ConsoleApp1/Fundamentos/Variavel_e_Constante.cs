using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hello.Fundamentos
{
    public class Variavel_e_Constante
    {
        public static void Executar(){
            
            //area da circunferencia
            // no c# tem que declarar o tipo da variavel, que nesse caso é double, que representa um valor real que aceita casas decimais 
            double raio = 4.5;
            raio = 5.5;
            //para constantes, primeiro tem que declarar que é uma constante, e depois o tipo dela. 
            const double pi = 3.14;

            System.Console.WriteLine(raio); 
            double area = pi * raio*raio;
            System.Console.WriteLine("area = " + area);

            // tipos internos 
            bool EstaChovendo = true; // tipo verdadeiro ou falso 

            byte idade = 45; //tipo inteiro com uma capacidade de armazenamento menor7

            sbyte saldo = sbyte.MinValue; // tipo inteiro com uma capacidade de armazenamento menor, semelhante ao byte, com a diferença de que ele consegue armazenar numeros negativos, o MinValue é para mostrar o menor valor que o sbyte consegue armazenar 

            short salario = short.MaxValue;// tipo inteiro com uma capacidade de armazenamento maior, semelhante , podendo armazenar numeros negativos e positivos

            int menorValor = int.MinValue;
            int maiorValor = int.MaxValue;
            //o int é o tipo inteiro com a maior capacidade de armazenamento, podendo armazenar numeros positivos e negativos e é o que é usado por padrão

            long PopMundial = long.MaxValue; //capacidade de armazenamento na casa dos bilhões 

            float PreçoMouse = 30.23f; // tipo que trabalha com casas decimais igual ao double, porem com uma capacidade de armazenamento menor, o double é o que é mais utilizado. 
        }
    }
}