using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle {
    class Estruturaif {
        public static void Executar() {
            bool bomcomportamento = false;
            string entrada;

            Console.Write("Digite a nota do Aluno: ");
            entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);

            Console.Write("Possui Bom Comportamento (S/N): ");
            entrada = Console.ReadLine();

            //if (entrada == "S" || entrada == "s")
            //bomcomportamento = true;
            //bomcomportamento = entrada == "S" || entrada == "s";
            bomcomportamento = entrada.ToLower() == "s";
            
            if(nota >= 9.0 && bomcomportamento) 
                {
                Console.WriteLine("Quadro de Honra!");
            }
            
        }
    }
}
