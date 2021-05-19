using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class operadoresunarios {
        public static void Executar() {
            var valornegativo = -5;
            var numero1 = 2;
            var numero2 = 3;
            var booleano = false;
            Console.WriteLine(-valornegativo);
            Console.WriteLine(!booleano);
            numero1++;

            Console.WriteLine(numero1);

            --numero1;
            Console.WriteLine(numero1);

            Console.WriteLine(numero1++ == --numero2);
            Console.WriteLine($"{numero1} {numero2}");
        }
    }
}
