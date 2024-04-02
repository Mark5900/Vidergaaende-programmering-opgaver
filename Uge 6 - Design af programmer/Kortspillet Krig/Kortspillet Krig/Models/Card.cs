using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kortspillet_Krig.Models
{
    public class Card
    {

        public int FaceValue { get; set; }

        public CardColor CardColor { get; set; }

        public string CardImage { get; set; }


    }

    public enum CardColor
    {
        Diamond,
        Hearts,
        Clubs,
        Spades
    }
}
