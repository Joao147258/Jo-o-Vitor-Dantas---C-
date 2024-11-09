using System;
using System.Collections.Generic;

using hello.Fundamentos;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", Fundamentos.Executar},
                {"Comentarios - Fundamentos", Comentarios.Executar},
                {"Variavel e constante - Fundamentos", Variavel_e_Constante.Executar},
                {"interferencia de tipos - Fundamentos", InterferenciaDeTipos.Executar},
                {"Interpolação de strings", Interpolação_de_Strings.Executar},
                {"Notação Ponto", NotaçãoPonto.Executar},
                {"Notação Ponto - Fundamentos", NotaçãoPonto.Executar},
                {"input console - Fundamentos", InputNoConsole.Executar},
                {"Formatando Numeros - Fundamentos", FormatandoNumeros.Executar},
                {"Converção - Fundamentos", Converção.Executar}
            });

            central.SelecionarEExecutar();
        }
    }
}