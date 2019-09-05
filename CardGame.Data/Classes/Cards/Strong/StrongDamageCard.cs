using CardGame.Data.Classes.Abstract;
using CardGame.Data.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Data.Classes.Cards.Strong
{
    public class StrongDamageCard : DamageCard
    {

        public StrongDamageCard(string image) : base(Constants.Cost, Constants.PointsOfEffect, image)
        {
        }
    }
}
