using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class operadoresaritmeticos {
        public static void Executar() {
            //Preço Desconto
            var preco = 1000.0;
            var imposto = 355;
            var desconto = 0.1;

            double total = preco + imposto;
            var totalcomdesconto = total - (total * desconto);
            Console.WriteLine("O preço final e: {0}", totalcomdesconto);

            //IMC
            double peso = 91.2;
            double altura = 1.82;
            double IMC = peso / Math.Pow(altura, 2);
            Console.WriteLine($"IMC é {IMC}.");

            //numeros Par/Impar
            int par = 24;
            int impar = 55;
            Console.WriteLine("{0}/2 tem resto {1}", par, par % 2);
            Console.WriteLine("{0}/2 tem resto {1}", impar, impar % 2);
        }
    }
}
