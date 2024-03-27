using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mekanikerværksted
{
    internal class Vaerfoerere : Mekanikere
    {
        private int _udnaevnelsesAar;
        private double _tillaeg;

        public Vaerfoerere(string navn, Adresse adresse, CprNr cprNr, string medarbejderNr, DateTime svendeproeveAar, double timeloen, int udnaevnelsesAar, double tillaeg) : base(navn, adresse, cprNr, medarbejderNr, svendeproeveAar, timeloen)
        {
            _udnaevnelsesAar = udnaevnelsesAar;
            _tillaeg = tillaeg;
        }

        public int UdnaevnelsesAar
        {
            get { return _udnaevnelsesAar; }
            set { _udnaevnelsesAar = value; }
        }

        public double Tillaeg
        {
            get { return _tillaeg; }
            set { _tillaeg = value; }
        }

        public override double BeregnUgeLøn()
        {
            return Timeloen * TimerPrUge + _tillaeg;
        }
    }
}
