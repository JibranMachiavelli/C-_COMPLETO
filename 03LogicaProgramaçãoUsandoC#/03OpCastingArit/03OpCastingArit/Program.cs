using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program {
        static void Main(string[] args) {
            
            //casting

            double a;
            int b;

            a = 5.1;
            b = (int)a;

            Console.WriteLine(b);
            Console.WriteLine("");

            int c = 5;
            int d = 2;

            double resultado = (double)c / d;

            Console.WriteLine(resultado);
            Console.WriteLine("");

            //Operadores

            int n1 = 3 + 4 * 2;
            int n2 = (3 + 4) * 2;
            int n3 = 17 % 3;
            double n4 = (double)10.0 / 8; //pode usar tanto (double) ou 0.00

            double f = 1.0, h = -3.0, i = -4.0;

            double delta = Math.Pow(h, 2.0) - 4 * f * i;

            double x1 = (-h + Math.Sqrt(delta)) / (2 * f);
            double x2 = (-h - Math.Sqrt(delta)) / (2 * f);

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(delta);
            Console.WriteLine(x1);
            Console.WriteLine(x2);
        }
    }
}