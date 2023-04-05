using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio10
{
    internal class MediaPonderada
    {
        public decimal nota1;
        public decimal nota2;
        public decimal resultadoMediaPonderada;
        public decimal CalcularMediaPonderada() 
        {
           resultadoMediaPonderada = ((nota1 * 5) + (nota2 * 5)) / 5 + 5;
           return resultadoMediaPonderada;
        }
    }
}
