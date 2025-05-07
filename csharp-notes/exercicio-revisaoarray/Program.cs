using System.Globalization;

namespace exercicio_revisaoarray;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Número de participante: ");
        int n = int.Parse(Console.ReadLine());
        double[] vect = new double[n];
        Console.WriteLine();

        Console.WriteLine("Altura de cada participante: ");
        double sum = 0;
        for (int i = 0; i < n; i++)
        {
            Console.Write(i + 1 + "o participante: ");
            vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            sum += vect[i];
        }
        double media = sum / n;

        Console.WriteLine("Media de alturas = " + media.ToString("F2", CultureInfo.InvariantCulture));

    }
}
