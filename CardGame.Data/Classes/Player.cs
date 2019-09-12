using CardGame.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Data.Classes
{
    public class Player : IPlayer
    {

        private const int health = 100;

        private const int armor = 0;

        private const int mana = 10;

        public Player(ObservableCollection<ICard> cards)
        {
            Cards = cards;
            Health = health;
            Armor = armor;
            Mana = mana;
            TurnsPoisoned = 0;
        }

        public ObservableCollection<ICard> Cards { get; set; }
        public int Health { get; set; }
        public int Armor { get; set; }
        public int Mana { get; set; }

        public int TurnsPoisoned { get; set; }
    }
}
