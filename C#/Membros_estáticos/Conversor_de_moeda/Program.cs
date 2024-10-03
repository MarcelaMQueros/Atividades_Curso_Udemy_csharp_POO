using System;
using System.Globalization;

namespace Atividade {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Qual a cotação do dólar? ");
            double cota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar? ");
            double qnt = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double resultado = Conversor.ValorPagar(cota, qnt);

            Console.WriteLine($"Valor a ser pago em reais = {resultado.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}