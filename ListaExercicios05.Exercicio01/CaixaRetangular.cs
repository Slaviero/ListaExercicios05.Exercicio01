using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios05.Exercicio01
{
    internal class CaixaRetangular
    {
        public decimal volume;
        public decimal baseCaixa;
        public decimal larguraCaixa;
        public decimal alturaCaixa;
        
        public decimal CalculaVolume()
        {
            volume = baseCaixa * alturaCaixa * larguraCaixa;
            return volume;
        }

    }
}
