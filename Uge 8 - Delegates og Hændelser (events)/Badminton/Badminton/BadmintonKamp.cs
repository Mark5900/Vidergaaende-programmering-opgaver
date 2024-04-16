using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Badminton
{
    internal class BadmintonKamp
    {
        private int _spiller1Score;
        private int _spiller2Score;
        private PointBeregning _pointBeregning;

        public BadmintonKamp(PointBeregning pointBeregning)
        {
            _pointBeregning = pointBeregning;
        }

        public void Spiller1VinderPoint()
        {
            _spiller1Score++;
        }

        public void Spiller2VinderPoint()
        {
            _spiller2Score++;
        }

        public int BeregnPoint()
        {
            return _pointBeregning(_spiller1Score, _spiller2Score);
        }
    }
}
