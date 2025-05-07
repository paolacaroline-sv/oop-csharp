using System.Globalization;

namespace exercicio_dolar;


class Program
{
    static void Main(string[] args)
    {
        Console.Write("Qual é a cotaçao do dolar? ");
        double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Quantos dólares você vai comprar? ");
        double compra = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);



        Console.WriteLine("Valor a ser pago em Reais = R$" + ConversorDeMoeda.Dolar(cotacao, compra).ToString("F2", CultureInfo.InvariantCulture));

    }
}
