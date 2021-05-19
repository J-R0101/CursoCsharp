using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class operadoreslogicos {
        public static void Executar() {
            var execultoutrabalho1 = false;
            var execultoutrabalho2 = true;

            bool comprouTv50 = execultoutrabalho1 && execultoutrabalho2; // && = i
            Console.WriteLine("Comprou a TV? {0}", comprouTv50);

            var comprousorvete = execultoutrabalho1 || execultoutrabalho2; // || = ou 
            Console.WriteLine("Comprou o sorvete? {0} ", comprousorvete);

            var comprouTv32 = execultoutrabalho1 ^ execultoutrabalho2; // ^ = ou exclusivo
            Console.WriteLine("Comprou a TV de 32? {0} ", comprouTv32);

            Console.WriteLine("Mais saudavel? {0} ", !comprousorvete); // negação logica
        }
    }
}
