using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class Conversoes {
        public static void Executar() {

            //conversão implicita
            int inteiro = 10;
            double quebrado = inteiro ;
            Console.WriteLine(quebrado);

            //conversão explicita
            double nota = 9.7;
            int notatruncada = (int) nota;
            Console.WriteLine("nota Truncada {0}", notatruncada );

            Console.WriteLine("Qual a sua Idade");
            string idadestring = Console.ReadLine();
            int idadeinteiro = int.Parse(idadestring);
            Console.WriteLine("Idade inserida: {0}", idadeinteiro);

            idadeinteiro = Convert.ToInt32(idadestring);
            Console.WriteLine("Resultado: {0}", idadeinteiro);

            Console.Write("Digite o primeiro Numero");
            string palavra = Console.ReadLine();
            int numero1 = 0;
            int.TryParse(palavra, out numero1);// aqui e uma tentativa de conversão
            Console.WriteLine("Resultado 1: {0}", numero1);

            Console.Write("Digite o segundo Numero");
            int.TryParse(Console.ReadLine(), out int numero2);// aqui e uma tentativa de conversão
            Console.WriteLine("Resultado 2: {0}", numero2);

        }
    }
}
