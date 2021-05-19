using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesMetodos {
    class Menbros {
        public static void Executar() {
            Pessoa sicrano = new Pessoa();
            sicrano.Nome = "junior";
            sicrano.Idade = 40;

            //Console.WriteLine($" {sicrano.Nome} tem {sicrano.Idade} anos.");
            sicrano.ApresentarNoConsole();

            var fulano = new Pessoa();
            fulano.Nome = "Maria";
            fulano.Idade = 51;

            var apresentaçãoDoFulano = fulano.Apresentar();
            Console.WriteLine(apresentaçãoDoFulano);


        }
    }
}
