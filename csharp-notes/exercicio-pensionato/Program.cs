namespace exercicio_pensionato;

class Program
{
    static void Main(string[] args)
    {
        Estudante[] vect = new Estudante[10];

        Console.Write("Quantos quartos serão alugados? ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine();

        
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"Aluguel #{i}");
            Console.Write("Nome: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string mail = Console.ReadLine();
            Console.Write("Quarto: ");
            int room = int.Parse(Console.ReadLine());
            vect[room] = new Estudante(name, mail);
            Console.WriteLine();
        }

        Console.WriteLine("Quartos ocupados:");

        for (int i = 0; i < 10; i++) {
            if (vect[i] != null)
            {
                Console.WriteLine(i + ": " + vect[i]);
            }
        }


    }
}
