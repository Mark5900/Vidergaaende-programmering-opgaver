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

        public Synsmand(string navn, Adresse adresse, CprNr cprNr, string medarbejderNr, DateTime svendeproeveAar, double timeloen, int synsAntal) : base(navn, adresse, cprNr, medarbejderNr, svendeproeveAar, timeloen)
        {
            _synsAntal = synsAntal;
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
