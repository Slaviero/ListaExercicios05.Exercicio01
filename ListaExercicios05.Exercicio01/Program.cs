namespace ListaExercicios05.Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CaixaRetangular caixaRetangular = new CaixaRetangular();

            Console.Write("Informe a base de sua caixa: ");
            caixaRetangular.baseCaixa = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Informe a altura de sua caixa: ");
            caixaRetangular.alturaCaixa = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Informe a largura de sua caixa: ");
            caixaRetangular.larguraCaixa = Convert.ToDecimal(Console.ReadLine());

            caixaRetangular.volume = caixaRetangular.CalculaVolume();
            Console.WriteLine($"O volume de sua caixa é {caixaRetangular.volume}.");
            Console.ReadLine();
        }
    }
}