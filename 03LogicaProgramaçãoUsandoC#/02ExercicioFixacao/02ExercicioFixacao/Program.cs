using System;
using System.Globalization;

namespace _01Exercicio // Note: actual namespace depends on the project name.
{
    internal class Program {
        static void Main(string[] args) {

            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produto:");
            Console.WriteLine(produto1 + " cujo preco e $" + preco1);
            Console.WriteLine(produto2 + " cujo preco e $" + preco2);
            Console.WriteLine("");
            Console.WriteLine("Regiostro: " + idade + " anos de idade, código " + codigo + " e genero: " + genero);
            Console.WriteLine("");

            Console.WriteLine(medida.ToString("F8"));
            Console.WriteLine(medida.ToString("F3"));
            Console.WriteLine(medida.ToString("F3",CultureInfo.InvariantCulture));

            /*
            Produto:
            Computador, cujo preço é 2100,00
            Mesa de escritório, cujo preco é 650.50

            Registro: 30 anos de idade, código 5290 e gênero: M

            Medida com oito casas decimais: 53,23456700
            Arredondamento (Tres casas decimais): 53,235
            Separador decimal invariant culture: 53.235
            */

        }
    }
}