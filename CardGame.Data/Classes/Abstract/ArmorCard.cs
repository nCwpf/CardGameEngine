using CardGame.Data.Common;
using CardGame.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Data.Classes.Abstract
{
    public abstract class ArmorCard:ICard
    {
        protected ArmorCard(int cost, int pointsOfEffect, string image)
        {
            Cost = cost;
            PointsOfEffect = pointsOfEffect;
            Position = Position.InDeck;
            Image = image;
        }

        public int Cost { get; set; }
        public int PointsOfEffect { get; set; }

        public TypeOfEffect TypeOfEffect => TypeOfEffect.Instant;

        public Position Position { get; set; }
        public string Image { get; set; }
    }
}
