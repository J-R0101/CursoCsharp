using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class operadoresrelacionais {
        public static void Executar() {
            //double nota = 6.0;
            Console.Write("Digite sua Nota: ");
            double.TryParse(Console.ReadLine(), out double nota);
            double notadecorte = 7.0;
            Console.WriteLine("Nota invalida? {0}", nota > 10.0);
            Console.WriteLine("Nota invalida? {0}", nota < 0.0);
            Console.WriteLine("Perfeito? {0}", nota == 10.0);
            Console.WriteLine("Tem como melhorar? {0}", nota != 10.0);
            Console.WriteLine("Passou por Media? {0}", nota >= notadecorte);
            Console.WriteLine("Recuperação? {0}", nota < notadecorte);
            Console.WriteLine("Reprovado? {0}", nota <= 3.0);
        }
    }
}
