using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio06
{
    internal class Conversor
    {
        public decimal tempFahrenheit;
        public decimal tempCelsius;
        public decimal ConversorCelciusParaFahrenheit() 
        {
            tempFahrenheit = (tempCelsius * 9 / 5) + 32;
            return tempFahrenheit;
        }
    }
}
