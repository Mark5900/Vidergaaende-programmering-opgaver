using Pizza_program;

int amountInt;
bool run;
PizzaOrderMethods pizzaOrderMethods = new PizzaOrderMethods();

Console.WriteLine("Velkommen til Pizza programmet");
Console.WriteLine("Du har nu følgende muligheder:");
Console.WriteLine("1. Bestil en pizza");
Console.WriteLine("2. Lav en pizza");
string input = Console.ReadLine().Trim().ToLower();

switch (input)
{
    case "1":
        while (true)
        {
            amountInt = 0;

            Console.WriteLine("Hvad for en pizza vil du have?");
            string pizza = Console.ReadLine().Trim().ToLower();

            if (string.IsNullOrEmpty(pizza))
            {
                Console.WriteLine("Du skal indtaste en pizza");
                continue;
            }
            Console.WriteLine("");

            run = true;
            while (run)
            {
                Console.WriteLine("Hvor mange vil du have? (Standard er 1)");
                string amount = Console.ReadLine().Trim().ToLower();

                if (string.IsNullOrEmpty(amount))
                {
                    amountInt = 1;
                }
                else if (!int.TryParse(amount, out amountInt))
                {
                    Console.WriteLine("Du skal indtaste et tal");
                    continue;
                }
                if (amountInt < 1)
                {
                    Console.WriteLine("Du skal indtaste et tal større end 0");
                    continue;
                }
                Console.WriteLine("");

                run = false;
            }

            pizzaOrderMethods.OrderPizza(pizza, amountInt);

            Console.WriteLine("Vil du bestille en pizza mere? (Ja/Nej)");
            string answer = Console.ReadLine().Trim().ToLower();

            if (answer == "nej")
            {
                pizzaOrderMethods = new PizzaOrderMethods();
                break;
            }
            Console.WriteLine("");
        }

        break;

        case "2":
            while (true)
            {
                List<string> ingredients = new List<string>();
                string size = "";

                Console.WriteLine("Hvad for en størrelse vil du have? (Lille/Mellem/Stor)");
                string sizeInput = Console.ReadLine().Trim().ToLower();

                if (sizeInput == "lille")
                {
                    size = "lille";
                }
                else if (sizeInput == "mellem")
                {
                    size = "mellem";
                }
                else if (sizeInput == "stor")
                {
                    size = "stor";
                }
                else
                {
                    Console.WriteLine("Du skal indtaste en størrelse");
                    continue;
                }
                Console.WriteLine("");

                run = true;
                while (run)
                {
                    Console.WriteLine("Hvad for nogle ingredienser vil du have?");
                    string ingredient = Console.ReadLine().Trim().ToLower();

                    if (string.IsNullOrEmpty(ingredient))
                    {
                        Console.WriteLine("Du skal indtaste en ingrediens");
                        continue;
                    }
                    Console.WriteLine("");

                    ingredients.Add(ingredient);

                    Console.WriteLine("Vil du have flere ingredienser? (Ja/Nej)");
                    string answer = Console.ReadLine().Trim().ToLower();

                    if (answer == "nej")
                    {
                        run = false;
                    }
                    Console.WriteLine("");
                }

                pizzaOrderMethods.MakePizza(ingredients, size);

                Console.WriteLine("Vil du lave en pizza mere? (Ja/Nej)");
                string answer2 = Console.ReadLine().Trim().ToLower();

                if (answer2 == "nej")
                {
                    pizzaOrderMethods = new PizzaOrderMethods();
                    break;
                }
                Console.WriteLine("");
            }
            break;
    default:
        Console.WriteLine("Du har indtastet noget forkert");
        return;
}