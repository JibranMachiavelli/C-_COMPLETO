using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program {
        static void Main(string[] args) {

            string frase = Console.ReadLine();
            
            Console.WriteLine("Voce digitou : " + frase);

            int y = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int z = x + y;

            Console.WriteLine("A soma é : " + z);

        }
    }
}