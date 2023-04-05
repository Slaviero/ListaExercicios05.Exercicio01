namespace Exercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conversor conversor = new Conversor();
            Console.Write("Informe a temperatura em graus Celsius: ");
            conversor.tempCelsius = Convert.ToDecimal(Console.ReadLine());

            conversor.tempFahrenheit = conversor.ConversorCelciusParaFahrenheit();
            Console.WriteLine($"A sua temperatura em Fahrenheit é de {conversor.tempFahrenheit} °F.");
        }
    }
}