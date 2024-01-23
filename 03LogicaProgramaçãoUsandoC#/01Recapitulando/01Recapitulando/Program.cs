using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program {
        static void Main(string[] args) {

            int idade = 32;
            string nome = "Maria";
            double saldo = 120.22002;

            Console.WriteLine(nome  + " tem, " + idade + " anos  e tem saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture ) + " reais."); //saida de numeros apenas 2 decimos.
        }
    }
}