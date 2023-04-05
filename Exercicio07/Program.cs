namespace Exercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Salario salario = new Salario();

            Console.Write("Informe o seu salário base: ");
            salario.salarioBase = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Informe a valor em vendas que fez no mês: ");
            salario.vendas = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Informe o percentual de comissão sobre suas vendas: : ");
            salario.comissao = Convert.ToDecimal(Console.ReadLine());

            salario.salarioFinal = salario.CalcularSalarioFinal();
            Console.WriteLine($"Nesse mês você recebeu o salario total de R$: {salario.salarioFinal}.");
        }
    }
}