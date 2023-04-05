namespace Exercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MediaPonderada mediaPonderada = new MediaPonderada();

            Console.Write("Insira a primeira nota: ");
            mediaPonderada.nota1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Insira a segunda nota: ");
            mediaPonderada.nota2 = Convert.ToDecimal(Console.ReadLine());

            mediaPonderada.resultadoMediaPonderada = mediaPonderada.CalcularMediaPonderada();
            Console.WriteLine($"Sua média ponderada é: {mediaPonderada.resultadoMediaPonderada}.");
        }
    }
}