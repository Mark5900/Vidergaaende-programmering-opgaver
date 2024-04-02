using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terninger_og_raflebægre
{
    internal class Die
    {
        private int value;
        private static Random rand = new Random();

        public Die()
        {
            Roll();
        }

        public void Roll()
        {
            value = rand.Next(1, 7);
        }

        public int GetValue()
        {
            return value;
        }
    }
}
