using CardGame.Data.Common;
using CardGame.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Data.Classes.Abstract
{
    public abstract class PoisonCard : ICard
    {
        protected PoisonCard(int cost, int pointsOfEffect, int duration, string image)
        {
            Cost = cost;
            PointsOfEffect = pointsOfEffect;
            Duration = duration;
            Position = Position.InDeck;
            Image = image;
        }

        public int Cost { get; set; }
        public int PointsOfEffect { get; set; }

        public TypeOfEffect TypeOfEffect => TypeOfEffect.Еxtended;

        public int Duration { get; set; }

        public Position Position { get; set; }

        public string Image { get; set; }
    }
}
