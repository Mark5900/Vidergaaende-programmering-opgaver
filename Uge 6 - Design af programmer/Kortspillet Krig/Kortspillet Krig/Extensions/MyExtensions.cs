using Kortspillet_Krig.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kortspillet_Krig.Extensions
{
    public static class MyExtensions
    {
        private static Random rng = new Random();

        public static void Shuffle(this List<Card> deck)
        {
            int elementsToShuffle = deck.Count;
            while (elementsToShuffle > 1)
            {
                elementsToShuffle--;
                int nextElementIndex = rng.Next(elementsToShuffle + 1);
                Card card = deck[nextElementIndex];
                deck[nextElementIndex] = deck[elementsToShuffle];
                deck[elementsToShuffle] = card;
            }
        }

    }
}
