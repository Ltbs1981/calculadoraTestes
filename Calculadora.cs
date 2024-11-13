using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadoraTestes
{
    public class Calculadora
    {
        public double Soma(double numero1, double numero2) => numero1 + numero2;

        public double Subtracao(double numero1, double numero2) => numero1 - numero2;

        public double Multiplicacao(double numero1, double numero2) => numero1 * numero2;

        public double Divisao(double numero1, double numero2)
        {
            if (numero2 == 0)
            {
                Console.WriteLine("O divisor não pode ser zero!");
                return 0;
            }
            else
            {
                return numero1 / numero2;
            }
        }

    }
}
