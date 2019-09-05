using CardGame.Data.Classes.Abstract;
using CardGame.Data.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Data.Classes.Cards.Weak
{
    public class WeakHealingCard : HealingCard
    {
        public WeakHealingCard(string image) : base(Constants.LowCost, Constants.LowPointsOfEffect, image)
        {
        }
    }
}
