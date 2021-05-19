using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class lendodados {
        public static void Executar() {

            Console.WriteLine("Qual e o seu Nome? ");
            string nome = Console.ReadLine();  //readline não pode receber um inteiro 


            Console.WriteLine("Qual sua Idade ");
            int idade = int.Parse(Console.ReadLine());  //desta maneira se faz uma alteração de caracteres para inteiro
                                                        //transforma isto "1" em isto 1 porem dara problema se for "abc" nao consegue transforma pois não tem numero

            Console.WriteLine("Qual e o seu Salario ");
            double salario = double.Parse(Console.ReadLine());

            Console.WriteLine($"{nome} {idade} R${salario}");

            /* using System.Globalization; acima do namespace
             * e colocando o codigo CultureInfo.InvariantCulture apos o Console.Readline() ele utilizara 
             * o ponto como separado de casas decimais em vez de pegar referencias do S.O do usuario
             */

        }
    }
}
