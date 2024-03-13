using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_program
{
    internal class Order
    {
        public string PizzaType { get; set; }
        public int Number { get; set; }
        public List<string> Ingredients { get; set; }
    }
}
