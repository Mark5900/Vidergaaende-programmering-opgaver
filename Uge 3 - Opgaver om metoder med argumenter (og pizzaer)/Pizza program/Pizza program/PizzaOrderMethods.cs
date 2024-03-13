using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Pizza_program
{
    internal class PizzaOrderMethods
    {
        private List<Order> _Order = new List<Order>();

        public void OrderPizza()
        {
            int amountInt;
            bool run;

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

                // Find the pizza in the list and add the number to the existing order
                // Else add a new order to the list
                var order = _Order.FirstOrDefault(x => x.PizzaType == pizza);
                if (order != null)
                {
                    order.Number += amountInt;
                    Console.WriteLine($"Du har nu bestilt {order.Number} {order.PizzaType} pizza(er)");
                }
                else
                {
                    _Order.Add(new Order { PizzaType = pizza, Number = amountInt });
                    Console.WriteLine($"Du har nu bestilt {amountInt} {pizza} pizza(er)");
                }

                Console.WriteLine("");

                Console.WriteLine("Vil du bestille en pizza mere? (Ja/Nej)");
                string answer = Console.ReadLine().Trim().ToLower();

                if (answer == "nej")
                {
                    Console.WriteLine("");
                    return;
                }
                Console.WriteLine("");
            }
            
        }

        public void MakePizza()
        {
            bool run;

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

                Console.WriteLine($"Du har bestilt en {size} pizza med følgende ingredienser:");
                foreach (var ingredient in ingredients)
                {
                    Console.WriteLine(ingredient);
                }

                Console.WriteLine("");

                Console.WriteLine("Vil du lave en pizza mere? (Ja/Nej)");
                string answer2 = Console.ReadLine().Trim().ToLower();

                if (answer2 == "nej")
                {
                    _Order.Add(new Order { PizzaType = "Custom", Number = 1, Ingredients = ingredients });
                    return;
                }
                Console.WriteLine("");
            }
        }

        
    }
}
