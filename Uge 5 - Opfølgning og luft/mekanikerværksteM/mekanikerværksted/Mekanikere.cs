using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mekanikerværksted
{
    internal class Mekanikere : Medarbejder
    {
        private int _svendeproeveAar;
        private double _timeloen;

        public Mekanikere(string navn, string adresse, int svendeproeveAar, double timeloen, CprNr cprNr, string medarbejderNr) : base(navn, adresse, cprNr, medarbejderNr)
        {
            _svendeproeveAar = svendeproeveAar;
            _timeloen = timeloen;
        }

        public int SvendeproeveAar
        {
            get { return _svendeproeveAar; }
            set { _svendeproeveAar = value; }
        }

        public double Timeloen
        {
            get { return _timeloen; }
            set { _timeloen = value; }
        }

        public override double BeregnUgeLøn()
        {
            return _timeloen * TimerPrUge;
        }
    }
}
