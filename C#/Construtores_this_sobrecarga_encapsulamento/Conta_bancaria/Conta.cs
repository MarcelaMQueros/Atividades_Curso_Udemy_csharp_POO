using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conta_bancaria {
    class Conta {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public Conta(int num, string tit) {
            Numero = num;
            Titular = tit;
        }
        public Conta(int num,string tit, double deposito) : this(num,tit){ 
            Deposito(deposito);
        }
        public void Deposito(double valor) {
            Saldo += valor;
        }
        public void Saque(double valor) {
            Saldo -= (valor + 5.0);
        }


        public override string ToString() {
            return $"Conta {Numero}, Titular: {Titular}, Saldo: $ {Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }


    }
}
