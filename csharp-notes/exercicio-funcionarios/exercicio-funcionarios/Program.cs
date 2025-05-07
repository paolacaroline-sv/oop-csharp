using System.Runtime.Intrinsics.X86;
using System;
using exercicio_funcionarios;
using System.Globalization;

Funcionario funcionario = new Funcionario(); 

Console.Write("Nome: ");
funcionario.Nome = Console.ReadLine();
Console.Write("Salário bruto: ");
funcionario.SalarioBruto = double.Parse(Console.ReadLine());
Console.Write("Imposto: ");
funcionario.Imposto = double.Parse(Console.ReadLine());
Console.WriteLine();


Console.WriteLine($"Funcionário: {funcionario}");
Console.WriteLine();

Console.Write("Digite a porcentagem para aumentar o salário: ");
double porcentagem = double.Parse(Console.ReadLine());
funcionario.AumentarSalario(porcentagem);

Console.WriteLine();

Console.Write($"Dados atualizados: {funcionario}");
