using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle {
    class EstruturaForeach {
        public static void Executar() {
            var palavra = "Oba!";

            foreach (var letra in palavra) {
                Console.WriteLine(letra);
            }
            var alunos = new string[] { "Ana", "Bia", "Carlos" };
            foreach (string aluno in alunos) {
                Console.WriteLine(aluno);
            }
        }
    }
}
