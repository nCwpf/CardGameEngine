using CardGame.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Data.Classes
{
    public class Player : IPlayer
    {
        public Player(List<ICard> cards, int health, int armor, int mana)
        {
            Cards = cards;
            Health = health;
            Armor = armor;
            Mana = mana;
        }

        public List<ICard> Cards { get; set; }
        public int Health { get; set; }
        public int Armor { get; set; }
        public int Mana { get; set; }
    }
}
