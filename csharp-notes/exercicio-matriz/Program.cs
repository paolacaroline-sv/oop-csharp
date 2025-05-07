Console.Write("Quantos numeros? ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine("Digite os elementos: ");


int[,] mat = new int[n, n];
for (int i = 0; i < n; i++)
{
    string[] valores = Console.ReadLine().Split(' ');

    for (int j = 0; j < n; j++)
    {
        mat[i, j] = int.Parse(valores[j]);
    }
}

Console.WriteLine("Diagonal principal: ");
for (int i = 0; i < n; i++)
{
    Console.Write(mat[i, i] + " ");
}


int soma = 0;
for (int i = 0;i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (mat[i, j] < 0)
        {
            soma++;
        }
    }
}

Console.Write("Números negativos: " + soma);
