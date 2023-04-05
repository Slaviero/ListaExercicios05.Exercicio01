namespace Exercicio09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MediaHarmonica mediaHarmonica = new MediaHarmonica();

            Console.Write("Informe a sua primeira nota: ");
            mediaHarmonica.nota1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe a sua segunda nota: ");
            mediaHarmonica.nota2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe a sua terceira nota: ");
            mediaHarmonica.nota3 = Convert.ToDouble(Console.ReadLine());

            mediaHarmonica.mediaHarmonica = mediaHarmonica.CalcularMediaHarmonica();
            Console.WriteLine($"A sua média Harmonica é {mediaHarmonica.mediaHarmonica}");
            s
            Console.ReadLine();
        }
    }
}