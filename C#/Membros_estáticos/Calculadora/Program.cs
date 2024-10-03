using System;
using System.Globalization;

namespace Atividade {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Valor do Raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double circulo = Calculadora.Circunferencia(raio);
            double volume = Calculadora.Volume(raio);
            Console.WriteLine($"Circunferência: {circulo.ToString("F2", CultureInfo.InvariantCulture)}\nVolume: {volume.ToString("F2", CultureInfo.InvariantCulture)}\nValor de PI: {Calculadora.PI.ToString("F2",
            CultureInfo.InvariantCulture)}" );
        }
    }
}