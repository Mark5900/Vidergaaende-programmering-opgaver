using Pizza_program;

PizzaOrderMethods pizzaOrderMethods = new PizzaOrderMethods();

while (true)
{
    string input = ProgramMenu();

    switch (input)
    {
        case "1":
            pizzaOrderMethods.OrderPizza();
            break;

        case "2":
            pizzaOrderMethods.MakePizza();
            break;
        default:
            Console.WriteLine("Du har indtastet noget forkert");
            return;
    }
}


string ProgramMenu()
{
    Console.WriteLine("Velkommen til Pizza programmet");
    Console.WriteLine("Du har nu følgende muligheder:");
    Console.WriteLine("1. Bestil en pizza");
    Console.WriteLine("2. Lav en pizza");
    string input = Console.ReadLine().Trim().ToLower();
    Console.WriteLine("");

    return input;
}