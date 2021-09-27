using System;

namespace Heron
{
    class Program
    {
        static void Main(string[] args)
        {
            // Objetivo: Calcule a área de um triângulo qualquer, dadas as medidas dos 3 lados. Exiba o semiperímetro e a área.

            Console.Write("Digite o Lado 1: ");
            double A = double.Parse(Console.ReadLine());

            Console.Write("Digite o Lado 2: ");
            double B = double.Parse(Console.ReadLine());

            Console.Write("Digite o Lado 3: ");
            double C = double.Parse(Console.ReadLine());

            double S = (A+B+C)/2;
            double p = Math.Sqrt((S*(S-A)*(S-B)*(S-C)));

            Console.WriteLine($"\nSemiperímetro: {Math.Round(p,2)}");
            Console.WriteLine($"Área: {S}");
        }
    }
}
