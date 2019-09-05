using CardGame.Data.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Data.Interfaces
{
    public interface ICard
    {
        int Cost { get; set; }

        int PointsOfEffect { get; set; }

        TypeOfEffect TypeOfEffect { get; }

        Position Position { get; set; }

        string Image { get; set; }
    }
}
