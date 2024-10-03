using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade {
    public static class Conversor {

        public static int IOF = 6;

        public static double ValorPagar(double cota, double qnt) {
            return (cota * qnt) + (((cota * qnt) * IOF) / 100);
        }

    }
}
