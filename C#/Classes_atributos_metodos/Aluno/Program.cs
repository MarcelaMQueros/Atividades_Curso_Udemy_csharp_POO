﻿using System;
using System.Globalization;

namespace Atividade {
    internal class Program {
        static void Main(string[] args) {
            Aluno aluno = new Aluno();
            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno: ");
            aluno.PrimeiraNota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.SegundaNota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.TerceiraNota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"NOTA FINAL = {aluno.NotaFinal().ToString("F2", CultureInfo.InvariantCulture)}");
            if (aluno.Aprovado()) {
                Console.WriteLine("APROVADO");
            }
            else {
                Console.WriteLine($"REPROVADO \nFALTARAM {aluno.NotaRestante().ToString("F2", CultureInfo.InvariantCulture)} PONTOS");
            }
        }
    }
}