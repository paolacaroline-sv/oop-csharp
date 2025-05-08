using System.Globalization;
using PriceTagsExercise.Entities;

Console.Write("Enter the number of products: ");
int n = int.Parse(Console.ReadLine());
List<Product> products = new List<Product>();

for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"Product #{i} data: ");
    Console.Write("Common, user or imported (c/u/i)? ");
    char productType = char.Parse(Console.ReadLine());
    Console.Write("Name: ");
    string productName = Console.ReadLine();
    Console.Write("Price: ");
    double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    switch (productType)
    {
        case 'u':
            Console.Write("Manufature date (DD/MM/YYYY): ");
            DateTime manufatureDate = DateTime.Parse(Console.ReadLine());
            products.Add(new UsedProduct(productName, productPrice, manufatureDate));
            break;

        case 'i':
            Console.Write("Customs fee: ");
            double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            products.Add(new ImportedProduct(productName, productPrice, customsFee));
            break;

        default:
            products.Add(new Product(productName, productPrice));
            break;
    }    
}

Console.WriteLine();
Console.WriteLine("PRICE TAGS:");
foreach (Product prod in products)
{
    Console.WriteLine(prod.PriceTag());
}