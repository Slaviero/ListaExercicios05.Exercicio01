namespace Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cilindro cilindro = new Cilindro();

            Console.Write("Informe o Raio do seu Cilindro: ");
            cilindro.raioCilindro = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe o Altura do seu Cilindro: ");
            cilindro.alturaCilindro = Convert.ToDouble(Console.ReadLine());

            cilindro.volCilindro = cilindro.calcularVolumeCilindro();

            Console.WriteLine($"O volume de seu cilindro é de {cilindro.volCilindro}");

            Console.ReadLine();
        }
    }
}