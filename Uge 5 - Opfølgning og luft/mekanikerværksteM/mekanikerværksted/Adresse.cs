using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mekanikerværksted
{
    internal class Adresse
    {
        public string Vej { get; set; }
        public string HusNr { get; set; }
        public string PostNr { get; set; }
        public string By { get; set; }

        public Adresse(string vej, string husNr, string postNr, string by)
        {
            Vej = vej;
            HusNr = husNr;
            PostNr = postNr;
            By = by;
        }

        public override string ToString()
        {
            return $"{Vej} {HusNr}, {PostNr} {By}";
        }
    }
}
