using exercicio_lista;

Console.Write("Quantos funcionários serão registrados? ");
int n = int.Parse(Console.ReadLine());

List<Funcionarios> lista = new List<Funcionarios>();


for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"Funcionário {i}#");
    Console.Write("Id: ");
    int id = int.Parse(Console.ReadLine());
    Console.Write("Nome: ");
    string nome = Console.ReadLine();
    Console.Write("Salario: ");
    double salario = double.Parse(Console.ReadLine());

    lista.Add(new Funcionarios(id, nome, salario));
    Console.WriteLine();
}


Console.Write("Entre o ID do funcionário que receberá o aumento salarial: ");
int idfunc = int.Parse(Console.ReadLine());
Funcionarios func = lista.Find(x => x.Id == idfunc);
if (func != null)
{
    Console.Write("Entre a porcentagem: ");
    double porcent = double.Parse(Console.ReadLine());
    func.Aumento(porcent);
}
else
{ 
    Console.WriteLine("Id inválido"); 
    
}

Console.WriteLine();
Console.WriteLine("Lista de funcionários atualizada: ");
foreach (Funcionarios todos in lista)
{
    Console.WriteLine(todos);
}
