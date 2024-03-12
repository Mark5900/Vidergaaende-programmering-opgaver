using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_program
{
    internal class PizzaOrderMethods
    {
        private List<Order> _Order = new List<Order>();

        public void OrderPizza(string pizzaType, int number)
        {
            // Find the pizza in the list and add the number to the existing order
            // Else add a new order to the list
            var order = _Order.FirstOrDefault(x => x.PizzaType == pizzaType);
            if (order != null)
            {
                order.Number += number;
                Console.WriteLine($"Du har nu bestilt {order.Number} {order.PizzaType} pizza(er)");
            }
            else
            {
                _Order.Add(new Order { PizzaType = pizzaType, Number = number });
                Console.WriteLine($"Du har nu bestilt {number} {pizzaType} pizza(er)");
            }

            Console.WriteLine(""); 
        }

        public void MakePizza(List<string> ingredients, string size)
        {
            Console.WriteLine($"Du har bestilt en {size} pizza med følgende ingredienser:");
            foreach (var ingredient in ingredients)
            {
                Console.WriteLine(ingredient);
            }

            Console.WriteLine("");
        }
    }
}
