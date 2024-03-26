using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mekanikerværksted
{
    internal class CprNr
    {
        private string _birthDate;
        private string _sequenceNumber;

        public CprNr(string bDate, string sNumber)
        {
            BirthDate = bDate;
            SequenceNumber = sNumber;
        }

        public string BirthDate
        {
            get { return _birthDate; }
            set { _birthDate = value; }
        }

        public string SequenceNumber
        {
            get { return _sequenceNumber; }
            set { _sequenceNumber = value; }
        }

        public override string ToString()
        {
            return _birthDate + "-" + _sequenceNumber;
        }
    }
}
