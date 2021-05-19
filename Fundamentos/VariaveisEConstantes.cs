using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class VariaveisEConstantes {
        public static void Executar () {
            // area da circunferencia
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;
            // PI = 3,1415; nao pode ser alterado pois e uma constante

            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("Area é " + area);

            // tipos internos

            bool estaChovendo = false;
            Console.WriteLine("esta chovendo " + estaChovendo);

            // byte so aceita valores + \sem sinal
            byte idade = 45;
            Console.WriteLine("Idade " + idade);

            //sbyte vai de -127 a +128 aceita valores tanto + quanto - \ byte com sinal
            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("Saldo de Gol " + saldoDeGols);
            //dar espaço entre o final da frase com a aspa dupla na concatenaçao para dar espaço no console
            short salario = short.MaxValue;
            Console.WriteLine("Salario " + salario);

            //mais usado dos inteiros \ com sinal
            int menorValor = int.MinValue;
            Console.WriteLine("Menor int.. " + menorValor);
            
            //inteiro sem sinal
            uint populaçaobrasileira = 207_600_000;
            Console.WriteLine("População Brasileira " + populaçaobrasileira);

            long menorvalorlong = long.MinValue;
            Console.WriteLine("Menor Valor Long " + menorvalorlong);

            //sem sinal
            ulong populaçaomundial = 7_600_000_000;
            Console.WriteLine("População Mundial " + populaçaomundial);

            // com float os literais tem que ser marcado com f no final 
            float preçodocomputador = 1299.99F;
            Console.WriteLine("Preço do Computador " + preçodocomputador);

            //mais usado dos reais
            double valordemercadodaapple = 1_000_000_000_000.00;
            Console.WriteLine("Valor Apple " + valordemercadodaapple);


            decimal distanciadasestrelas = decimal.MaxValue;
            Console.WriteLine("Distancia da Estrela " + distanciadasestrelas);

            //armazenar letra com aspas simples e uma letra somente duas da erro
            char letra = 'b';
            Console.WriteLine("Letra " + letra);

            //para uma cadeia de caracteres ou seja um texto 
            string texto = "Seja bem vindo ao curso de C#";
            Console.WriteLine(texto);

                




        }
    }
}
