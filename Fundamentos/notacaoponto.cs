using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class notacaoponto {
        public static void Executar() {
            var saudaçao = "ola ".ToUpper().Insert(3, " World! ").Replace(" World! ", " Mundo! ");
            Console.WriteLine(saudaçao);

            Console.WriteLine("teste".Length);

            //cuidado ao usar comotoção ponto em variaveis vazias
            string valorimportante = null;
            Console.WriteLine(valorimportante?.Length); //se tira a interrogção gera erro
            Console.WriteLine(valorimportante?.Length);   //colocando interrogação torna segura a navegação com comotação ponto para não gera erro
        }



    }
}
