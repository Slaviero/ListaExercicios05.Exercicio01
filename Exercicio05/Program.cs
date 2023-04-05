namespace Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Esfera esfera = new Esfera();

            Console.Write("Informe o Raio de sua esfera: ");
            esfera.raioEsfera = Convert.ToDouble(Console.ReadLine());

            esfera.volAredondado = esfera.VolumeEsfera();
            Console.WriteLine($"O volume de sua esfera é de {esfera.volAredondado} cm cubicos.");

            Console.ReadLine();
        }
    }
}