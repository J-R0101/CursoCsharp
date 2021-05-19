using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle {
    class EstruturaDoWhile {
        public static void Executar() {
            string entrada;
            do {
                Console.WriteLine("Qual seu nome?");
                entrada = Console.ReadLine();

                Console.WriteLine("Seja bem-vindo {0}", entrada);
                Console.WriteLine("Deseja continua? (S/N)");
                entrada = Console.ReadLine();
            } while (entrada.ToLower() == "s");
         }
    }
}
