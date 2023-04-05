using System.Linq.Expressions;

namespace Exercicio08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lata lata = new Lata();

            string tipoLata;
            do
            {
                Console.Write("Sua lata de olho é cilindrica ou retangular ( 1 = Cilindrica ou 2 = Retangular ): ");
                tipoLata = Console.ReadLine();

                if (tipoLata != "1" && tipoLata != "2")
                {
                    Console.Clear();
                    Console.WriteLine("!!!O valor inserido deve ser 1 ou 2!!!\n");
                }
            } while (tipoLata != "1" && tipoLata != "2");

            if (tipoLata == "1")
            {
                
                Console.Write("Informe o Raio do sua Lata Cilindrica: ");
                lata.raioCilindro = Convert.ToDouble(Console.ReadLine());

                Console.Write("Informe o Altura do sua lata Cilindrica: ");
                lata.alturaCilindro = Convert.ToDecimal(Console.ReadLine());

                lata.volCilindro = lata.CalculoVolumeLataCilindrica();
                Console.WriteLine($"O volume de sua lata é de {lata.volCilindro}");
                Console.ReadLine();
            }
            else if (tipoLata == "2")
            {
                Console.Write("Informe a base de sua lata Retangular: ");
                lata.baseLata = Convert.ToDecimal(Console.ReadLine());

                Console.Write("Informe a altura de sua lata Retangular: ");
                lata.alturaLata = Convert.ToDecimal(Console.ReadLine());

                Console.Write("Informe a largura de sua lata Retangular: ");
                lata.larguraLata = Convert.ToDecimal(Console.ReadLine());

                lata.volRetangulo = lata.CalculoVolumeLataRetangular();

                Console.WriteLine($"O volume de sua lata Retangular é {lata.volRetangulo}.");
                Console.ReadLine();
            }
        }
    }
}