namespace exercicio_params;

class Program
{
    static void Main(string[] args)
    {

        int s1 = Calculator.Sum(2, 3); //quantos elementos for preciso;
        int s2 = Calculator.Sum(2, 3, 4, 5);

        Console.WriteLine(s1);
        Console.WriteLine(s2);

    }
}
