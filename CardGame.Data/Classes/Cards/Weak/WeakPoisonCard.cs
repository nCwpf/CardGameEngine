using CardGame.Data.Classes.Abstract;
using CardGame.Data.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Data.Classes.Cards.Weak
{
    public class WeakPoisonCard : PoisonCard
    {
        public WeakPoisonCard(string image) : 
            base(Constants.LowCost, Constants.LowPointsOfEffect, Constants.Duration, image)
        {
        }
    }
}
