using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class operadorternario {
        public static void Executar() {
            var nota = 7.0;
            bool bomcomportamento = true;
            string resultado = nota >= 7.0 && bomcomportamento ? "Aprovado" : "Reprovado";
            Console.WriteLine(resultado);
        }
    }
}
