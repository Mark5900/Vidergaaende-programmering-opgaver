using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mekanikerværksted
{
    internal class Mekanikere : Medarbejder
    {
        private DateTime _svendeproeveAar;
        private double _timeloen;

        public Mekanikere(string navn, Adresse adresse, CprNr cprNr, string medarbejderNr, DateTime svendeproeveAar, double timeloen) : base(navn, adresse, cprNr, medarbejderNr)
        {
            _svendeproeveAar = svendeproeveAar;
            _timeloen = timeloen;
        }

        public DateTime SvendeproeveAar
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
