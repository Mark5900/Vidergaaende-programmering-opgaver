using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mekanikerværksted
{
    internal class Synsmand : Mekanikere
    {
        private int _synsAntal;

        public Synsmand(string navn, string adresse, int svendeproeveAar, int syns, CprNr cprNr, string medarbejderNr) : base(navn, adresse, svendeproeveAar, 0, cprNr, medarbejderNr)
        {
            _synsAntal = syns;
        }

        public int SynsAntal
        {
            get { return _synsAntal; }
            set { _synsAntal = value; }
        }

        public override double BeregnUgeLøn()
        {
            return _synsAntal * 290;
        }
    }
}
