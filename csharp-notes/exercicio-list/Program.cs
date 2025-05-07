class Program
{
    static void Main(string[] args)
    {
        List<string> list = new List<string>();

        list.Add("Maria");
        list.Add("Bob");
        list.Insert(1, "Pedro");
        list.Insert(2, "Axex");
        list.Add("Alana");

        foreach (string item in list)
        {
            Console.WriteLine(item);
        }

                string s1 = list.Find(x => x[0] == 'A');
        Console.WriteLine("Find" + s1);

        string s2 = list.FindLast(x => x[0] == 'A');
        Console.WriteLine("FindLast" + s2);

        int pos1 = list.FindIndex(x => x[0] == 'A');
        Console.WriteLine(pos1);

        int pos2 = list.FindLastIndex(x => x[0] == 'A');
        Console.WriteLine(pos2);

        List<string> list2 = list.FindAll(x => x.Length == 5);
        foreach (string item in list2)
        {
            Console.WriteLine(item);
        }
    }
}