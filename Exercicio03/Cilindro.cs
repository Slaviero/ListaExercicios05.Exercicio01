using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    internal class Cilindro
    {
        public double volCilindro;
        public double raioCilindro;
        public double alturaCilindro;
        double PI = (double)Math.PI;

        public double calcularVolumeCilindro()
        {
            volCilindro = PI * Math.Sqrt(raioCilindro) * alturaCilindro;
            return volCilindro;
        }
    }
}
