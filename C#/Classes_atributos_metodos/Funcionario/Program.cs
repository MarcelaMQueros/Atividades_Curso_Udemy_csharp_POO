
using System;
using System.ComponentModel;
using System.Globalization;

namespace Atividade {
    internal class Program {
        static void Main(string[] args) {

            Funcionario funcionario = new Funcionario();
            Console.Write("Nome: ");
            funcionario.Nome = Console.ReadLine();
            Console.Write("Salario bruto:");
            funcionario.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            funcionario.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine($"Funcionario: {funcionario}");
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            funcionario.AumentarSalario(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.Write($"Dados atualizados: {funcionario}");
        }
    }
}