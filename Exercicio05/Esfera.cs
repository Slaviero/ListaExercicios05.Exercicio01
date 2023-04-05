using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio05
{
    internal class Esfera
    {
        public double raioEsfera;
        double PI = Math.PI;
        double volEsfera;
        public double volAredondado;
        public double VolumeEsfera()
        {
            volEsfera = (4 * PI * (Math.Pow(raioEsfera, 3))) / 3;
            volAredondado = Math.Round(volEsfera, 2);
            return volAredondado;
        }
    }
}
