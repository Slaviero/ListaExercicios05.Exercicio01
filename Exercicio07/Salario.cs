using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio07
{
    internal class Salario
    {
        decimal auxPercentual = 100;
        public decimal salarioFinal;
        public decimal vendas;
        public decimal comissao;
        public decimal salarioBase;

        public decimal CalcularSalarioFinal()
        {
            salarioFinal = salarioBase + (vendas * (comissao / auxPercentual));
            salarioFinal = Math.Round(salarioFinal, 2);
            return salarioFinal;
        }
    }
}
