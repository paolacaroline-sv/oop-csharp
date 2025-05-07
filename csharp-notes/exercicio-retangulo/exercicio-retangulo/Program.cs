using System.Globalization;
using exercicio_retangulo;

Retangulo x;
x = new Retangulo();

Console.WriteLine("Entre a largura e altura do retângulo: ");
Console.Write("Largura: ");
x.largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Altura: ");
x.altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.WriteLine();

Console.WriteLine("AREA = " + x.Area().ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("PERIMETRO = " + x.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("DIAGONAL = " + x.Diagonal().ToString("F2", CultureInfo.InvariantCulture));

Console.WriteLine();

