using CardGame.Data.Classes.Abstract;
using CardGame.Data.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Data.Classes.Cards.Strong
{
    public class StrongPoisonCard : PoisonCard
    {
        public StrongPoisonCard(string image) : 
            base(Constants.Cost, Constants.PointsOfEffect, Constants.Duration, image)
        {
        }
    }
}
