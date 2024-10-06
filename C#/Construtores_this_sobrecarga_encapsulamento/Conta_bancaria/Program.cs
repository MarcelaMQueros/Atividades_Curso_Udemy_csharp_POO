using System;
using System.Globalization;

namespace Conta_bancaria {
    internal class Program {
        static void Main(string[] args) {

            Conta C;
            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Hávera depósito inicial (s/n): ");
            char simnao = char.Parse(Console.ReadLine().ToUpper());

            
            if (simnao == 'S') {
                Console.Write("Entre o valor de depósito inicial: ");
                double dep_inicial = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                C = new Conta(numero, titular, dep_inicial);
            }
            else {
                C = new Conta(numero, titular);
            }
            

            
            Console.WriteLine($"Dados da conta:\n{C}");

            Console.Write("Entre um valor para déposito: ");

            C.Deposito(double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture));
            Console.WriteLine($"Dados da conta atualizados:\n{C}");

            Console.Write("Entre um valor para Saque: ");

            C.Saque(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine($"Dados da conta atualizados:\n{C}");


        }
    }
}