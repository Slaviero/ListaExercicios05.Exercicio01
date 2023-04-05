using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio08
{
    internal class Lata
    {
        decimal PI = (decimal)Math.PI;
        decimal raioAoQuadrado;
        public decimal volCilindro;
        public double raioCilindro;
        public decimal alturaCilindro;
        public decimal volRetangulo;
        public decimal baseLata;
        public decimal alturaLata;
        public decimal larguraLata;

        public decimal CalculoVolumeLataCilindrica()
        {
            raioAoQuadrado = Convert.ToDecimal(Math.Sqrt(raioCilindro));

            volCilindro = PI * raioAoQuadrado * alturaCilindro;
            volCilindro = Math.Round(volCilindro, 2);
            return volCilindro;
        }
        public decimal CalculoVolumeLataRetangular()
        {
            volRetangulo = baseLata * alturaLata * larguraLata;
            volRetangulo = Math.Round(volRetangulo, 2);
            return volRetangulo;
        }
    }
}
