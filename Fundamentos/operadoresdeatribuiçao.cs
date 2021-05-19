using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class operadoresdeatribuiçao {
        public static void Executar() {
            var num1 = 3;
            num1 += 10; // num1 = num1 + 10
            num1 = 13; // num1 = num1 - 3
            num1 *= 5; // num1 = num1 * 5
            num1 /= 2; // num1 = num1 / 2

            Console.WriteLine(num1);

            int a = 1;
            int b = a;

            a++; // a = a + 1;
            b--; // b = b - 1;

            Console.WriteLine($"{a} {b}");

            dynamic c = new System.Dynamic.ExpandoObject();
            c.nome = "joao";
            dynamic d = c;
            d.nome = "maria";

            Console.WriteLine(c.nome);
        }
    }
}
