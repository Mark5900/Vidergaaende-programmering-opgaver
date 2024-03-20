using Opret_en_simpel_klasse;

List <Beer> listBeers = new List<Beer>();



while (true)
{
    Console.WriteLine("Write the name of the beer");
    string name = Console.ReadLine();
    Console.WriteLine("Write the size of the beer");
    int size = int.Parse(Console.ReadLine());
    Console.WriteLine("Write the prize of the beer");
    int prize = int.Parse(Console.ReadLine());
    Console.WriteLine("Write the alcohol procent of the beer");
    double procent = double.Parse(Console.ReadLine());

    listBeers.Add(new Beer(name, size, prize, procent));

    Console.WriteLine("Do you want to add another beer? (yes/no)");
    string answer = Console.ReadLine();
    if (answer == "no")
    {
        foreach (var beer in listBeers)
        {
            Console.WriteLine(beer.ToString());
        }
        break;
    }
}
