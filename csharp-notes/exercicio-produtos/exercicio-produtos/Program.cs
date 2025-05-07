using System.Globalization;
using exercicio_produtos;


Console.WriteLine("* Entre os dados do produto: ");
Console.Write("Nome: ");
string nome = Console.ReadLine();
Console.Write("Preço: ");
double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Quantidade no estoque: ");
int qtd = int.Parse(Console.ReadLine());
Console.WriteLine();

Produto p = new Produto(nome, preco, qtd);



Console.WriteLine($"DADOS DO PRODUTO: {p}");
Console.WriteLine();

Console.Write("* Digite número de produtos a ser adicionado ao estoque: ");
int alterar = int.Parse(Console.ReadLine());
p.AdicionarProduto(alterar);
Console.WriteLine("Dados Atualizados: " + p);
Console.WriteLine();

Console.Write("* Digite número de produtos a ser adicionado ao estoque: ");
alterar = int.Parse(Console.ReadLine());
p.RemoverProduto(alterar);
Console.WriteLine("Dados Atualizados: " + p);


