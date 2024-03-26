using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mekanikerværksted
{
    internal abstract class Medarbejder
    {
        private string _navn;
        private string _adresse;
        private const int _timerPrUge = 37;
        private CprNr _cprNr;
        private string _medarbejderNr;

        public Medarbejder(string navn, string adresse, CprNr cprNr, string medarbejderNr)
        {
            _navn = navn;
            _adresse = adresse;
            _cprNr = cprNr;
            _medarbejderNr = medarbejderNr;
        }

        public string Navn
        {
            get { return _navn; }
            set { _navn = value; }
        }

        public string Adresse
        {
            get { return _adresse; }
            set { _adresse = value; }
        }

        public abstract double BeregnUgeLøn();

        public int TimerPrUge //og den tilhørende access metode, bemærk readOnly, dvs get!
        {
            get { return _timerPrUge; }
        }

        public CprNr CprNr
        {
            get { return _cprNr; }
            set { _cprNr = value; }
        }

        public string MedarbejderNr
        {
            get { return _medarbejderNr; }
            set { _medarbejderNr = value; }
        }

        public override string ToString()
        {
            return "Navn: " + _navn + "\nAdresse: " + _adresse + "\nCprNr: " + _cprNr + "\nMedarbejderNr: " + _medarbejderNr + "\nUgeløn: " + BeregnUgeLøn() + "\nCprNr: " + _cprNr.ToString() + "\nMedarbejderNr: " + _medarbejderNr;
        }
    }
}
