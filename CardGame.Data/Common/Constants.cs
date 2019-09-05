using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Data.Common
{
    public static class Constants
    {
        private const int lowCost = 2;
        private const int cost = 3;
        private const int pointsOfEffect = 20;
        private const int duration = 10;

        public static int LowCost => lowCost;
        public static int Cost => cost;

        public static int PointsOfEffect => pointsOfEffect;

        public static int LowPointsOfEffect => pointsOfEffect / 2;

        public static int PoisonPointsOfEffect => Constants.PointsOfEffect / 5;

        public static int LowPoisonPointsOfEffect => Constants.PoisonPointsOfEffect / 2;

        public static int Duration => duration;
    }
}
