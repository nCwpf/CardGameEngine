using CardGame.Data.Classes.Cards.Strong;
using CardGame.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameEngine.Services
{
    public class CreateDeckService
    {


        public CreateDeckService()
        {
            Deck = new ObservableCollection<ICard>();
            Deck = Suffle();
        }

        public ObservableCollection<ICard> Deck { get; set; }

        private ObservableCollection<ICard> Suffle()
        {
            while (Deck.Count < 30)
            {
                Deck.Add(new StrongDamageCard(""));
            }
            return Deck;
        }
    }
}
