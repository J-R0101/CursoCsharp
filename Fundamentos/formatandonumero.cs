using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos {
    class formatandonumero {
        public static void Executar() {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1"));//faz o aredondamento do numero
            Console.WriteLine(valor.ToString("C"));//transforma em moeda corrente
            Console.WriteLine(valor.ToString("P"));//transforma em porcentagem
            Console.WriteLine(valor.ToString("#.##"));//tbm faz o arredontamento do numero

            CultureInfo cultura = new CultureInfo("pt-BR");
            Console.WriteLine(valor.ToString("C0", cultura));

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("d10"));//coloca zero a esquerda ate complerta o total de caracteres  
            /* usando using System.Globalization; acima do namespace 
             * pode ser utilizado o CultureInfo cultura = new CultureInfo("");
             * e dentro das aspas dupla a sigla da lingaguem e do pais ao qual 
             * quer trazer a cultura para o codigo
             */
        }
    }
}
