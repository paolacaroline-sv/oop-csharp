namespace exercicio_estudantes;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Quantos quartos serão alugados? ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine();

        Estudante[] vec = new Estudante[10];

        for (int i = 1; i <= 10; i++) {
            Console.WriteLine($"Aluguel #{i}");
            Console.Write("Nome: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Quarto: ");
            int room = int.Parse(Console.ReadLine());

            vec[room] = new Estudante(name, email);
            Console.WriteLine();
        }

        Console.WriteLine("Quartos ocupados: ");
        for (int i = 1; i <= 10; i++) {
            if (vec[i] != null)
            {
                Console.WriteLine($"{i}: {vec[i]}");
            }
        }
    }
}
