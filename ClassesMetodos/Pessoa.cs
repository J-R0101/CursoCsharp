using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesMetodos {
    class Pessoa {
        public string  Nome;
        public int Idade;

        public string Apresentar() {
            return string.Format($"Olá me chamo {Nome} e tenho {Idade} anos.");
        }
        public void ApresentarNoConsole() {
            Console.WriteLine(Apresentar());
        }
        public void Zera() {
            Nome = "";
            Idade = 0;

        }

    }
}
