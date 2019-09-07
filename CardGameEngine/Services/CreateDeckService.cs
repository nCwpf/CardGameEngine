using CardGame.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameEngine.Services
{
    public class CreateDeckService
    {
        public CreateDeckService(List<ICard> deck)
        {
            Deck = deck;
            Deck = Suffle();
        }

        public List<ICard> Deck { get; set; }

        private List<ICard> Suffle()
        {
            Random random = new Random();
            List<int> numbers = new List<int>();
            List<ICard> cards = new List<ICard>();
            while (cards.Count!=Deck.Count)
            {
                int number = random.Next();
                if (numbers.Contains(number))
                {
                    continue;
                }
                else
                {
                    cards.Add(Deck[number]);
                }
            }
            return cards;
        }
    }
}
