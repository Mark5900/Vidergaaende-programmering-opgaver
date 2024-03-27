using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mekanikerværksted
{
    internal class Firma : IharAdresse
    {
        public string Navn { get; set; }
        public Adresse Adresse { get; set; }

        public Firma(string navn, Adresse adresse)
        {
            Navn = navn;
            Adresse = adresse;
        }

        public override string ToString()
        {
            return Navn + " " + Adresse;
        }
    }
}
