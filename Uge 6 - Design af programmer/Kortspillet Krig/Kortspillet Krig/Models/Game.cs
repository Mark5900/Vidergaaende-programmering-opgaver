using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kortspillet_Krig.Extensions;

namespace Kortspillet_Krig.Models
{
    public class Game
    {

        private readonly List<Card> deck;

        public Game()
        {
            deck = InitializeDeck();
            deck.Shuffle();

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="player"></param>
        /// <returns>Returns the selected card if found or else returns null.</returns>
        public Card SelectCard()
        {
            Card selectedCard = deck.First();
            deck.Remove(selectedCard);

            return selectedCard;
        }

        private List<Card> InitializeDeck()
        {
            List<Card> mydeck = new List<Card>
            {
                new Card { CardColor = CardColor.Clubs, FaceValue = 1, CardImage = "AC" },
                new Card { CardColor = CardColor.Clubs, FaceValue = 2, CardImage = "2C" },
                new Card { CardColor = CardColor.Clubs, FaceValue = 3, CardImage = "3C" },
                new Card { CardColor = CardColor.Clubs, FaceValue = 4, CardImage = "4C" },
                new Card { CardColor = CardColor.Clubs, FaceValue = 5, CardImage = "5C" },
                new Card { CardColor = CardColor.Clubs, FaceValue = 6, CardImage = "6C" },
                new Card { CardColor = CardColor.Clubs, FaceValue = 7, CardImage = "7C" },
                new Card { CardColor = CardColor.Clubs, FaceValue = 8, CardImage = "8C" },
                new Card { CardColor = CardColor.Clubs, FaceValue = 9, CardImage = "9C" },
                new Card { CardColor = CardColor.Clubs, FaceValue = 10, CardImage = "10C" },
                new Card { CardColor = CardColor.Clubs, FaceValue = 11, CardImage = "JC" },
                new Card { CardColor = CardColor.Clubs, FaceValue = 12, CardImage = "QC" },
                new Card { CardColor = CardColor.Clubs, FaceValue = 13, CardImage = "KC" },

                new Card { CardColor = CardColor.Diamond, FaceValue = 1, CardImage = "AD" },
                new Card { CardColor = CardColor.Diamond, FaceValue = 2, CardImage = "2D" },
                new Card { CardColor = CardColor.Diamond, FaceValue = 3, CardImage = "3D" },
                new Card { CardColor = CardColor.Diamond, FaceValue = 4, CardImage = "4D" },
                new Card { CardColor = CardColor.Diamond, FaceValue = 5, CardImage = "5D" },
                new Card { CardColor = CardColor.Diamond, FaceValue = 6, CardImage = "6D" },
                new Card { CardColor = CardColor.Diamond, FaceValue = 7, CardImage = "7D" },
                new Card { CardColor = CardColor.Diamond, FaceValue = 8, CardImage = "8D" },
                new Card { CardColor = CardColor.Diamond, FaceValue = 9, CardImage = "9D" },
                new Card { CardColor = CardColor.Diamond, FaceValue = 10, CardImage = "10D" },
                new Card { CardColor = CardColor.Diamond, FaceValue = 11, CardImage = "JD" },
                new Card { CardColor = CardColor.Diamond, FaceValue = 12, CardImage = "QD" },
                new Card { CardColor = CardColor.Diamond, FaceValue = 13, CardImage = "KD" },

                new Card { CardColor = CardColor.Hearts, FaceValue = 1, CardImage = "AH" },
                new Card { CardColor = CardColor.Hearts, FaceValue = 2, CardImage = "2H" },
                new Card { CardColor = CardColor.Hearts, FaceValue = 3, CardImage = "3H" },
                new Card { CardColor = CardColor.Hearts, FaceValue = 4, CardImage = "4H" },
                new Card { CardColor = CardColor.Hearts, FaceValue = 5, CardImage = "5H" },
                new Card { CardColor = CardColor.Hearts, FaceValue = 6, CardImage = "6H" },
                new Card { CardColor = CardColor.Hearts, FaceValue = 7, CardImage = "7H" },
                new Card { CardColor = CardColor.Hearts, FaceValue = 8, CardImage = "8H" },
                new Card { CardColor = CardColor.Hearts, FaceValue = 9, CardImage = "9H" },
                new Card { CardColor = CardColor.Hearts, FaceValue = 10, CardImage = "10H" },
                new Card { CardColor = CardColor.Hearts, FaceValue = 11, CardImage = "JH" },
                new Card { CardColor = CardColor.Hearts, FaceValue = 12, CardImage = "QH" },
                new Card { CardColor = CardColor.Hearts, FaceValue = 13, CardImage = "KH" },

                new Card { CardColor = CardColor.Spades, FaceValue = 1, CardImage = "AS" },
                new Card { CardColor = CardColor.Spades, FaceValue = 2, CardImage = "2S" },
                new Card { CardColor = CardColor.Spades, FaceValue = 3, CardImage = "3S" },
                new Card { CardColor = CardColor.Spades, FaceValue = 4, CardImage = "4S" },
                new Card { CardColor = CardColor.Spades, FaceValue = 5, CardImage = "5S" },
                new Card { CardColor = CardColor.Spades, FaceValue = 6, CardImage = "6S" },
                new Card { CardColor = CardColor.Spades, FaceValue = 7, CardImage = "7S" },
                new Card { CardColor = CardColor.Spades, FaceValue = 8, CardImage = "8S" },
                new Card { CardColor = CardColor.Spades, FaceValue = 9, CardImage = "9S" },
                new Card { CardColor = CardColor.Spades, FaceValue = 10, CardImage = "10S" },
                new Card { CardColor = CardColor.Spades, FaceValue = 11, CardImage = "JS" },
                new Card { CardColor = CardColor.Spades, FaceValue = 12, CardImage = "QS" },
                new Card { CardColor = CardColor.Spades, FaceValue = 13, CardImage = "KS" }
            };

            return mydeck;
        }
    }
}
