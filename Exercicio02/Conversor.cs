using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    internal class Conversor
    {
        public double celsius;
        public double Fahrenheit;

        public double ConversorTemperatura()
        {
            celsius = (Fahrenheit - 32) * 5 / 9;
            return celsius;
        }
    }
}
