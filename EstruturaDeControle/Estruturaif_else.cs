using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle {
    class Estruturaif_else {
        public static void Executar() {
            double nota = 7.0;

            if (nota >= 7.0) {
                Console.WriteLine("Aprovado!");
                Console.WriteLine("Nao fez mais que sua obrigação....");
            } else {
                Console.WriteLine("Recuperação");
            }
        }
    }
}
