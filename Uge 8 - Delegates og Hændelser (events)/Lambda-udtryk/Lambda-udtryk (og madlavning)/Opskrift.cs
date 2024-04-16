using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_udtryk__og_madlavning_
{
    internal class Opskrift
    {
        public string Navn { get; set; }
        public string Svaerhedsgrad { get; set; }
        public int Tid { get; set; }
        public List<string> Ingredienser { get; set; }
    }
}
