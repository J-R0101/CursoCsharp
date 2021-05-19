using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class Inferencia {
        public static void Executar () {
            var nome = "leonardo";
            // nome = 123 uma vez declarada a variavel em string nao da para redeclara em inteiro
            Console.WriteLine(nome);
            //int idade;
            var idade = 35;
            // idade = 35 variaveis tem que ser declaradas e inicializadas antes nao da para declara depois / gera erro
            // a nao ser que seja uma variavel int ai pode ser declarada e inicializade depois 
            Console.WriteLine(idade);

            int a;
            a = 3;

            int b = 2;

            Console.WriteLine(a + b);
        }
    }
}
