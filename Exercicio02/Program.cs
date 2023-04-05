namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conversor conversor = new Conversor();

            Console.Write("Insira a temperatura em Graus Fahrenheit: ");
            conversor.Fahrenheit = Convert.ToDouble(Console.ReadLine());

            conversor.celsius = conversor.ConversorTemperatura();
            Console.WriteLine($"A tempratura em graus Celsius é de: {conversor.celsius}");
            Console.ReadLine();
        }
    }
}