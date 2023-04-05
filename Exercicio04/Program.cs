namespace Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Consumo consumo = new Consumo();

            Console.WriteLine("Informe a kilometragem inicial do seu veículo: ");
            consumo.kmInicial = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe a kilometragem final do seu veículo: ");
            consumo.kmFinal = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Quantos litros de gasolina foram gastos nesse percurso? ");
            consumo.litrosGastos = Convert.ToDouble(Console.ReadLine());

            consumo.consumoPorKm = consumo.CalcularConsumo();
            Console.WriteLine($"O seu consumo de combustível nessa viagem foi de {consumo.consumoPorKm} km por litro.");
        }
    }
}