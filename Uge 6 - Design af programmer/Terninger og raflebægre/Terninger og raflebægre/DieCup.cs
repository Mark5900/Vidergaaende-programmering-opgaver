using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terninger_og_raflebægre
{
    internal class DieCup
    {
        Die d1;
        Die d2;

        public DieCup()
        {
            d1 = new Die();
            d2 = new Die();
        }

        public int GetValue()
        {
            return d1.GetValue() + d2.GetValue();
        }

        public void Roll()
        {
            d1.Roll();
            d2.Roll();
        }

        public override string ToString()
        {
            return $"{d1.GetValue()} + {d2.GetValue()} = {GetValue()}";
        }
    }
}
