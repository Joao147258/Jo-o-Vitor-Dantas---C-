namespace hello.Fundamentos
{
    public class teste
    {
        public static void Executar()
        {
            
            void Exibir(){
                string curso = "C# criando primeira aplicação";
                System.Console.WriteLine(curso);

                string Nome = "joão";
                string Sobrenome = " dantas";

                System.Console.WriteLine($"Nome do aluno: {Nome + Sobrenome}");

            }

            Exibir();
             
        }
    }
}