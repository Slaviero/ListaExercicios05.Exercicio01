using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04
{
    internal class Consumo
    {
        public double kmFinal;
        public double kmInicial;
        public double litrosGastos;
        double kmPercorridos;
        public double consumoPorKm;
        public double CalcularConsumo() 
        {
            kmPercorridos = kmFinal - kmInicial;
            consumoPorKm = kmPercorridos / litrosGastos;

            return consumoPorKm;

        }
    }
}
