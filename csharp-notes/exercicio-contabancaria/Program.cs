using System.Drawing;
using System.Globalization;

namespace exercicio_contabancaria;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("*BANCO INTERBANK*");


        Console.Write("Entre o número da conta: ");
        int numero = int.Parse(Console.ReadLine());

        Console.Write("Entre o titular da conta: ");
        string titular = Console.ReadLine();

        Console.Write("Haverá depósito inicial (s/n)? ");
        char inicial = char.Parse(Console.ReadLine());
        double saldo = 0.0;

        if (inicial != 'n' || inicial != 'N')
        {
            Console.Write("Entre o valor de depósito inicial: ");
            saldo = double.Parse(Console.ReadLine().ToString(CultureInfo.InvariantCulture));
        }

        ContaBancaria conta = new ContaBancaria(numero, titular, saldo);

        Console.WriteLine();
        Console.WriteLine("Dados da Conta: ");
        Console.WriteLine(conta);
        Console.WriteLine();


        Console.Write("Entre um valor para depósito: ");
        double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        conta.Depositar(deposito);

        Console.WriteLine("Dados da conta atualizado: ");
        Console.WriteLine(conta);
        Console.WriteLine();

        Console.Write("Entre um valor para saque: ");
        double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        conta.Sacar(saque);

        Console.WriteLine("Dados da conta atualizado: ");
        Console.WriteLine(conta);
        Console.WriteLine();



    }
}
