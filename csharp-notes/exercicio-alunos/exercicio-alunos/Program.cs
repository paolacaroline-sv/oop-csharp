using System.Globalization;
using exercicio_alunos;

Aluno aluno = new Aluno();

Console.Write("Nome do aluno: ");
aluno.Nome = Console.ReadLine();
Console.WriteLine("Digite as três notas do aluno: ");
aluno.n1 = double.Parse(Console.ReadLine());
aluno.n2 = double.Parse(Console.ReadLine());
aluno.n3 = double.Parse(Console.ReadLine());

Console.WriteLine("NOTA FINAL = ", aluno.NotaFinal());
Console.WriteLine();

if (aluno.Aprovacao())
{
    Console.WriteLine("APROVADO");
}
else
{
    Console.WriteLine("REPROVADO");
    Console.WriteLine("FALTARAM " + aluno.NotaRestante().ToString("F2", CultureInfo.InvariantCulture) + " PONTOS");
}