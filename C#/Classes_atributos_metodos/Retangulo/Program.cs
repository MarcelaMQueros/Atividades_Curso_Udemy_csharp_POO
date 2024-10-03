using System;
using System.Globalization;

namespace Atividade {
    internal class Program {
        static void Main(string[] args) {
            Retangulo R = new Retangulo();
            Console.WriteLine("Entre a largura e altura do retangulo: ");
            R.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            R.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"AREA = {R.Area().ToString("F2", CultureInfo.InvariantCulture)}\nPERÍMETRO = {R.Perimetro().ToString("F2", CultureInfo.InvariantCulture)}\nDIAGONAL = {R.Diagonal().ToString("F2", CultureInfo.InvariantCulture)}");
            
        }
    }
}